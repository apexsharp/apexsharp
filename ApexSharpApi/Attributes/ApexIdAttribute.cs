using System;
using System.Collections.Generic;
using System.Text;

namespace ApexSharpApi.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ApexIdAttribute : Attribute
    {
        public ApexIdAttribute(string refName)
        {
            ReferencePropertyName = refName;
        }

        public string ReferencePropertyName { get; }
    }
}
