using System;
using System.Collections.Generic;
using System.Text;

namespace ApexSharpApi.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IgnoreUpdateAttribute : Attribute
    {
    }
}
