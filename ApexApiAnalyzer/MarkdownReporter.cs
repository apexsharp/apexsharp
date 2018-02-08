using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexApiAnalyzer
{
    public class MarkdownReporter
    {
        public static string GetReport(IEnumerable<ClassReference> classes, bool notImplementedOnly = false, bool ignoreApexSharp = true)
        {
            var sb = new StringBuilder();
            classes = classes.Where(c => c != null)
                .OrderBy(c => c.Namespace)
                .ThenBy(c => c.Name);

            if (notImplementedOnly)
            {
                classes = classes.Where(c => !c.HasImplementation);
            }

            var lastNamespace = string.Empty;
            foreach (var c in classes)
            {
                if (ignoreApexSharp && c.Namespace.StartsWith("Apex.ApexSharp"))
                {
                    continue;
                }

                if (c.Namespace != lastNamespace)
                {
                    sb.AppendLine("## " + c.Namespace + " namespace");
                    lastNamespace = c.Namespace;
                }

                var ni = c.HasImplementation ? string.Empty : " (not implemented)";
                sb.AppendLine("#### " + c.Name + " class" + ni);

                var constructors = c.Constructors.Values.OrderBy(m => m.Signature);
                if (constructors.Any())
                {
                    foreach (var m in constructors)
                    {
                        sb.Append("* new ");
                        sb.AppendLine(m.Signature);
                    }
                }

                var methods = c.Methods.Values.OrderBy(m => m.Signature);
                if (methods.Any())
                {
                    foreach (var m in methods)
                    {
                        sb.Append("* ");
                        sb.AppendLine(m.Signature);
                    }
                }

                var properties = c.Properties.Values.OrderBy(m => m.Name);
                if (properties.Any())
                {
                    foreach (var p in properties)
                    {
                        sb.Append("* ");
                        sb.AppendLine(p.Signature);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
