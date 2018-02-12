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
}
