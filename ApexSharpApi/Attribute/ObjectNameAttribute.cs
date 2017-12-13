using System;

namespace ApexSharpApi.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ObjectNameAttribute : System.Attribute
    {
        public ObjectNameAttribute(string salesForceObjectName)
        {
            SalesForceObjectName = salesForceObjectName;
        }

        public string SalesForceObjectName { get; set; }
    }
}