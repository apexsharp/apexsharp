using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ApexSharpApi.Attribute;

namespace ApexSharpApi
{
    public class SoqlCreator
    {
        // ToDo : Remove All this duplicate code
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


        public string GetSoql<T>()
        {
            List<string> soqlList = Reflection<T>();
            return soqlList[0];
        }

        private List<string> Reflection<T>()
        {
            List<string> dbFieldInfoList = new List<string>();

            // foreach (PropertyInfo membner in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))

            foreach (var membner in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                dbFieldInfoList.Add(membner.GetValue(null).ToString());
            }
            return dbFieldInfoList;
        }
    }
}