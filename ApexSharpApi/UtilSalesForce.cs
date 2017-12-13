using System.Linq;
using System.Text.RegularExpressions;
using ApexSharpApi.Attribute;

namespace ApexSharpApi
{
    public class UtilSalesForce
    {
        // Check to see if the value passed is a Salesforce ID        
        public static bool IsSalesforceId(string id)
        {
            Regex regex = new Regex(@"[a-zA-Z0-9]{18}");
            var match = regex.Match(id);
            return match.Success;
        }

        public string GetSalesForceObjectName<T>()
        {
            string objectName = typeof(T).Name;
            ObjectNameAttribute objectNameAttrbute = typeof(T).GetCustomAttributes(typeof(ObjectNameAttribute), true).FirstOrDefault() as ObjectNameAttribute;
            if (objectNameAttrbute != null)
            {
                objectName = objectNameAttrbute.SalesForceObjectName;
            }
            return objectName;
        }
    }
}