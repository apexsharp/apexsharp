using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApexApiAnalyzer
{
    public class SalesForceClassInfo
    {
        // Is this a SF class or class created by the user.
        public bool IsCustom { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
    }
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
            return new List<SalesForceClassInfo>();
        }


        // Format the apex code
        public string FormatApex(string apexCode)
        {
            return "";
        }
    }
}
