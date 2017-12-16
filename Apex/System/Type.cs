namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_type.htm#apex_methods_system_type
    /// </summary>
    public class Type
    {
        // infrastructure
        public Type(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Type));
            }
        }

        // API
        public bool equals(object typeToCompare)
        {
            return Self.equals(typeToCompare);
        }

        public static Type forName(string fullyQualifiedName)
        {
            return Implementation.forName(fullyQualifiedName);
        }

        public static Type forName(string @namespace, string name)
        {
            return Implementation.forName(@namespace, name);
        }

        public string getName()
        {
            return Self.getName();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public object newInstance()
        {
            return Self.newInstance();
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
