using System;
using System.IO;
using System.Text;
using ApexParser;

namespace ApexSharpApi
{
    public class CodeConverter
    {
        public static void ConvertToCSharp(DirectoryInfo apexLocation, DirectoryInfo cSharpLocation, string nameSpace)
        {
            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert APEX to C#
            ApexSharpParser.ConvertToCSharp(apexLocation.FullName, cSharpLocation.FullName, nameSpace);
        }

        public static void ConvertToApex(DirectoryInfo cSharpLocation, DirectoryInfo apexLocation, int version)
        {

            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert C# to Apex
            ApexSharpParser.ConvertToApex(cSharpLocation.FullName, apexLocation.FullName, version);
        }

        public static void ConvertToCSharp(FileInfo apexFile, DirectoryInfo cSharpLocation, string nameSpace)
        {
            if (!apexFile.Exists)
            {
                throw new FileNotFoundException(apexFile.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert APEX to C#
            var apexClass = File.ReadAllText(apexFile.FullName);
            var csharpClass = ApexSharpParser.ConvertApexToCSharp(apexClass, nameSpace);

            // Write the converted file to the target directory
            var csharpClassName = Path.ChangeExtension(apexFile.Name, "cs");
            var csharpFullName = Path.Combine(cSharpLocation.FullName, csharpClassName);
            File.WriteAllText(csharpFullName, csharpClass);
        }

        public static void ConvertToApex(FileInfo cSharpFile, DirectoryInfo apexLocation, int version)
        {
            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpFile.Exists)
            {
                throw new FileNotFoundException(cSharpFile.FullName);
            }

            // Convert C# to Apex
            var csharpCode = File.ReadAllText(cSharpFile.FullName);

            foreach (var convertedClass in ApexSharpParser.ConvertToApex(csharpCode))
            {
                var apexFileName = Path.ChangeExtension(convertedClass.Key, ".cls");
                var apexFile = Path.Combine(apexLocation.FullName, apexFileName);
                File.WriteAllText(apexFile, convertedClass.Value);

                var metaFileName = Path.ChangeExtension(apexFile, ".cls-meta.xml");
                var metaFile = new StringBuilder();

                metaFile.AppendLine("<?xml version = \"1.0\" encoding = \"UTF-8\"?>");
                metaFile.AppendLine("<ApexClass xmlns = \"http://soap.sforce.com/2006/04/metadata\">");
                metaFile.AppendLine($"<apiVersion>{version}.0</apiVersion>");
                metaFile.AppendLine("<status>Active</status>");
                metaFile.AppendLine("</ApexClass>");

                File.WriteAllText(metaFileName, metaFile.ToString());
                Console.WriteLine(metaFileName);
            }
        }
    }
}
