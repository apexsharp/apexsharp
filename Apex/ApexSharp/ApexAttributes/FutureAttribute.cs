using System;

namespace Apex.ApexSharp.ApexAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Future : Attribute
    {
        public bool callout { get; set; }
    }
}