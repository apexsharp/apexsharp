using System;

namespace Apex.ApexSharp.ApexAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class TransientAttribute : Attribute
    {
        public TransientAttribute()
        {
        }
    }
}