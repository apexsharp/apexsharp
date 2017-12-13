using System;
using System.Collections.Generic;
using System.Text;

namespace Apex.ApexSharp.Implementation
{
    /// <summary>
    /// This is a marker attribute for discovering the API implementations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class ImplementsAttribute : Attribute
    {
        public ImplementsAttribute(Type type) => Type = type;

        public Type Type { get; }
    }
}
