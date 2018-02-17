using System;

namespace ApexSharpApi.Attributes
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