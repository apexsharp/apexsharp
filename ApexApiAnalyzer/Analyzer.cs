using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using Apex.ApexSharp.Implementation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ApexParser.ApexSharpParser;

namespace ApexApiAnalyzer
{
    public class Analyzer
    {
        public Dictionary<string, ClassReference> Classes { get; } =
            new Dictionary<string, ClassReference>(StringComparer.InvariantCultureIgnoreCase);

        public Dictionary<string, ClassReference> ProcessUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return Classes;
            }

            if (!url.EndsWith(".zip", StringComparison.InvariantCultureIgnoreCase))
            {
                // github: download zipped master branch by default
                var uri = new Uri(url);
                if (uri.Host == "github.com" && string.IsNullOrWhiteSpace(uri.Query))
                {
                    url = url + "/archive/master.zip";
                }
            }

            var wc = new WebClient();
            var bytes = wc.DownloadData(url);
            using (var ms = new MemoryStream(bytes))
            {
                ProcessZipFile(ms);
            }

            return Classes;
        }

        public Dictionary<string, ClassReference> ProcessDirectories(params string[] paths)
        {
            if (paths == null || !paths.Any(t => !string.IsNullOrWhiteSpace(t)))
            {
                return Classes;
            }

            foreach (var path in paths)
            {
                var dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    continue;
                }

                var files = dir.GetFiles("*.cls", SearchOption.AllDirectories);
                var apexClasses = files.Select(f => File.ReadAllText(f.FullName));
                ProcessApexClasses(apexClasses.ToArray());
            }

            return Classes;
        }

        public Dictionary<string, ClassReference> ProcessZipFiles(params string[] zipFiles)
        {
            if (zipFiles == null || !zipFiles.Any(t => !string.IsNullOrWhiteSpace(t)))
            {
                return Classes;
            }

            foreach (var fileName in zipFiles)
            {
                using (var file = File.OpenRead(fileName))
                {
                    ProcessZipFile(file);
                }
            }

            return Classes;
        }

        private void ProcessZipFile(Stream file)
        {
            string ReadFile(ZipArchiveEntry entry)
            {
                using (var stream = entry.Open())
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }

            var zip = new ZipArchive(file, ZipArchiveMode.Read, false);
            var apexClasses =
                from entry in zip.Entries.OfType<ZipArchiveEntry>()
                where entry.Name.EndsWith(".cls", StringComparison.InvariantCultureIgnoreCase)
                select ReadFile(entry);

            ProcessApexClasses(apexClasses.ToArray());
        }

        public Dictionary<string, ClassReference> ProcessApexClasses(params string[] apexTexts)
        {
            if (apexTexts == null || !apexTexts.Any(t => !string.IsNullOrWhiteSpace(t)))
            {
                return ProcessCSharpClasses();
            }

            var csharpClasses = apexTexts.Select(c => ConvertApexToCSharp(c)).ToArray();
            return ProcessCSharpClasses(csharpClasses);
        }

        public Dictionary<string, ClassReference> ProcessCSharpClasses(params string[] csharpTexts)
        {
            if (csharpTexts == null || !csharpTexts.Any(t => !string.IsNullOrWhiteSpace(t)))
            {
                return Classes;
            }

            // process non-empty entries
            var trees = csharpTexts.Where(t => !string.IsNullOrWhiteSpace(t)).Select(t => CSharpSyntaxTree.ParseText(t)).ToArray();
            var roots = trees.Select(tree => (CompilationUnitSyntax)tree.GetRoot()).ToArray();
            var compilation = CSharpCompilation.Create("ApexTest")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddReferences(MetadataReference.CreateFromFile(typeof(Apex.System.System).Assembly.Location))
                .AddSyntaxTrees(trees);

            // extract all method calls
            foreach (var tree in trees)
            {
                // process valid classes
                var model = compilation.GetSemanticModel(tree);
                var root = tree.GetRoot() as CompilationUnitSyntax;
                if (root == null)
                {
                    continue;
                }

                ClassReference GetOrCreateClass(INamedTypeSymbol classSymbol)
                {
                    var classKey = classSymbol.ContainingNamespace.ToString() + "." + classSymbol.Name; // not ToString()
                    return Classes.GetOrAdd(classKey, n => new ClassReference
                    {
                        Name = classSymbol.Name,
                        Namespace = classSymbol.ContainingNamespace.ToString(),
                        HasImplementation = HasImplementation(classSymbol)
                    });
                };

                // all methods are referenced by invocation expresions
                foreach (var methodCall in root.DescendantNodes().OfType<InvocationExpressionSyntax>())
                {
                    var methodSymbolInfo = model.GetSymbolInfo(methodCall);
                    var methodSymbol = methodSymbolInfo.Symbol;
                    if (methodSymbol == null)
                    {
                        methodSymbol = methodSymbolInfo.CandidateSymbols.FirstOrDefault();
                    }

                    if (methodSymbol == null ||
                        methodSymbol.ContainingType == null ||
                        methodSymbol.ContainingAssembly == null ||
                        methodSymbol?.ContainingAssembly?.Name != nameof(Apex))
                    {
                        continue;
                    }

                    var classSymbol = methodSymbol.ContainingType;
                    var classRef = GetOrCreateClass(classSymbol);
                    var methodSignature = GetMemberSignature(classSymbol.ToString(), methodSymbol.ToString());
                    if (methodSignature.StartsWith("implicit operator") || methodSignature.StartsWith("explicit operator"))
                    {
                        // type cast operators are C#-specific and are not parts of the API
                        continue;
                    }

                    var methodRef = classRef.Methods.GetOrAdd(methodSignature, s => new MethodReference
                    {
                        Name = methodSymbol.Name,
                        IsStatic = methodSymbol.IsStatic,
                        Signature = methodSignature,
                        FullSignature = methodSymbol.ToString(),
                        Class = classRef
                    });
                }

                // constructors are referenced by object creation expressions
                foreach (var constructor in root.DescendantNodes().OfType<ObjectCreationExpressionSyntax>())
                {
                    var constructorSymbolInfo = model.GetSymbolInfo(constructor);
                    var constructorSymbol = constructorSymbolInfo.Symbol;
                    if (constructorSymbol == null)
                    {
                        constructorSymbol = constructorSymbolInfo.CandidateSymbols.FirstOrDefault();
                    }

                    if (constructorSymbol == null ||
                        constructorSymbol.ContainingType == null ||
                        constructorSymbol.ContainingAssembly == null ||
                        constructorSymbol?.ContainingAssembly?.Name != nameof(Apex))
                    {
                        continue;
                    }

                    var classSymbol = constructorSymbol.ContainingType;
                    var classRef = GetOrCreateClass(classSymbol);
                    var constructorSignature = GetMemberSignature(classSymbol.ToString(), constructorSymbol.ToString());
                    var constructorRef = classRef.Constructors.GetOrAdd(constructorSignature, s => new ConstructorReference
                    {
                        Name = constructorSymbol.Name,
                        IsStatic = constructorSymbol.IsStatic,
                        Signature = constructorSignature,
                        FullSignature = constructorSymbol.ToString(),
                        Class = classRef
                    });
                }

                // properties are referenced by member access expressions
                foreach (var property in root.DescendantNodes().OfType<MemberAccessExpressionSyntax>())
                {
                    var propertySymbolInfo = model.GetSymbolInfo(property);
                    var propertySymbol = propertySymbolInfo.Symbol as IPropertySymbol;
                    if (propertySymbol == null)
                    {
                        propertySymbol = propertySymbolInfo.CandidateSymbols.OfType<IPropertySymbol>().FirstOrDefault();
                    }

                    if (propertySymbol == null ||
                        propertySymbol.ContainingType == null ||
                        propertySymbol.ContainingAssembly == null ||
                        propertySymbol?.ContainingAssembly?.Name != nameof(Apex))
                    {
                        continue;
                    }

                    var classSymbol = propertySymbol.ContainingType;
                    var classRef = GetOrCreateClass(classSymbol);
                    var propertySignature = GetMemberSignature(classSymbol.ToString(), propertySymbol.ToString());
                    var propertyRef = classRef.Properties.GetOrAdd(propertySignature, s => new PropertyReference
                    {
                        Name = propertySymbol.Name,
                        IsStatic = propertySymbol.IsStatic,
                        Signature = propertySignature,
                        FullSignature = propertySymbol.ToString(),
                        Class = classRef
                    });
                }
            }

            return Classes;
        }

        private bool HasImplementation(ISymbol classSymbol)
        {
            if (classSymbol == null || classSymbol.ContainingNamespace == null)
            {
                return false;
            }

            var className = $"{classSymbol.ContainingNamespace.ToString()}.{classSymbol.Name}";
            return HasImplementation(className);
        }

        // some built-in types are either generic or non-mockable and implemented
        private static HashSet<string> ImplementedTypes = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
        {
            "Apex.System.List", "Apex.System.Map", "Apex.System.Set", "Apex.System.ID", "Apex.System.StringExtensions"
        };

        public static bool HasImplementation(string className)
        {
            if (ImplementedTypes.Contains(className))
            {
                return true;
            }

            // other types are checked for the stub implementation
            var type = typeof(Apex.System.System).Assembly.GetType(className);
            if (type == null)
            {
                return false;
            }

            var implementation = Implementor.GetDefaultImplementation(type);
            var isStub = implementation is StubImplementation;
            return !isStub;
        }

        private static string GetMemberSignature(string classSignature, string memberSignature)
        {
            if (memberSignature == null || classSignature == null)
            {
                return memberSignature;
            }

            if (memberSignature.StartsWith(classSignature + "."))
            {
                memberSignature = memberSignature.Substring(classSignature.Length + 1);
            }

            // collapse generic method signatures
            if (classSignature.Contains("<"))
            {
                var className = classSignature.Substring(0, classSignature.IndexOf("<"));
                var methodPrefixes = GenericMethods.GetOrDefault(className);
                if (methodPrefixes != null)
                {
                    foreach (var prefix in methodPrefixes)
                    {
                        if (memberSignature.StartsWith(prefix + "("))
                        {
                            memberSignature = prefix + "(...)";
                            break;
                        }
                    }
                }
            }

            return memberSignature;
        }

        private static Dictionary<string, string[]> GenericMethods { get; } =
            new Dictionary<string, string[]>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "Apex.System.List", new[] { "add", "addAll", "List" } },
                { "Apex.System.Map", new[] { "containsKey", "equals", "get", "getAll", "put", "putAll", "Map" } },
                { "Apex.System.Set", new[] { "add", "addAll", "contains", "containsAll", "Set" } },
            };

        public static void AnalyzeCSharpSources()
        {
            var tree = CSharpSyntaxTree.ParseText(
            @"using Apex.System;

            namespace ApexTest
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        var map = new Map<int, string>();
                        map.put(1, ""Hello"");

                        var json = JSON.serializePretty(map);
                        var length = json.Length;
                    }
                }
            }");

            var root = (CompilationUnitSyntax)tree.GetRoot();
            var compilation = CSharpCompilation.Create("ApexTest")
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
                .AddReferences(MetadataReference.CreateFromFile(typeof(Apex.System.System).Assembly.Location))
                .AddSyntaxTrees(tree);

            var model = compilation.GetSemanticModel(tree);
            var nameInfo = model.GetSymbolInfo(root.Usings[0].Name);
            var systemSymbol = (INamespaceSymbol)nameInfo.Symbol;

            foreach (var ns in systemSymbol.GetMembers()) // GetNamespaceMembers())
            {
                Console.WriteLine(ns.Name);
            }

            // decode the var type
            var mapDeclaration = root.DescendantNodes().OfType<LocalDeclarationStatementSyntax>().First();
            var symbolInfo = model.GetSymbolInfo(mapDeclaration.Declaration.Type);
            var typeSymbol = symbolInfo.Symbol;

            Console.WriteLine("The variable type: {0}", typeSymbol);
            Console.WriteLine("Defined in the assembly: {0}", typeSymbol.ContainingAssembly.Name);

            var mapDeclarator = root.DescendantNodes().OfType<VariableDeclaratorSyntax>().FirstOrDefault();
            var mapInfo = model.GetSymbolInfo(mapDeclarator.Initializer);

            // display all method calls
            foreach (var methodCall in root.DescendantNodes().OfType<InvocationExpressionSyntax>())
            {
                var mapPutSymbol = model.GetSymbolInfo(methodCall).Symbol;
                Console.WriteLine("Method call: {0}", mapPutSymbol);
                Console.WriteLine("Containing type: {0}", mapPutSymbol.ContainingType);
                Console.WriteLine("Containing namespace: {0}", mapPutSymbol.ContainingType.ContainingNamespace);
                Console.WriteLine("Containing type name: {0}", mapPutSymbol.ContainingType.Name);
                Console.WriteLine("Method name: {0}", mapPutSymbol.Name);
                Console.WriteLine("Method signature: {0}", mapPutSymbol.ToString().Substring(mapPutSymbol.ContainingType.ToString().Length + 1));
                Console.WriteLine("Defined in the assembly: {0}", mapPutSymbol.ContainingAssembly);
            }

            Console.ReadLine();
        }
    }
}
