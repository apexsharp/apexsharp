using System;

namespace Apex.ApexSharp.ApexAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RestResourceAttribute : Attribute
    {
        public string urlMapping { get; set; }
    }
}