using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexApiAnalyzer
{
    public class ApiAnalyzer
    {
        // Return a list of objects that are used in the code. This assume you have access to objectlist.Json
        public List<String> GetAllObjectsUsed(string cSharpCode)
        {
            return new List<string>();
        }

        // Go through the code and convert Class names, Method names to match case. For example if we have LIST<STRING> make it List<string> or System.DEBUG should be System.debug
        public string MatchCaseNames(string apexCode)
        {
            return "";
        }

        public List<SalesForceClassInfo> GetCallingClasses(string cSharpCode)
        {
            var analyzer = new Analyzer();
            analyzer.ProcessCSharpClasses(cSharpCode);

            // note: this list currently doesn't include custom classes
            var classes =
                from classRef in analyzer.Classes.Values
                from method in classRef.Methods.Values
                select new SalesForceClassInfo
                {
                    IsCustom = false,
                    ClassName = classRef.Name,
                    MethodName = method.Name
                };

            return classes.ToList();
        }

        // Format the apex code
        public string FormatApex(string apexCode)
        {
            return ApexParser.ApexSharpParser.IndentApex(apexCode);
        }
    }
}
