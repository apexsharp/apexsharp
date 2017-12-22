namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;
    using IEquatableOfType = global::System.IEquatable<Type>;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_type.htm#apex_methods_system_type
    /// </summary>
    public class Type : IEquatableOfType
    {
        // infrastructure
        public Type(dynamic self)
        {
            Self = self;
        }

        internal dynamic Self { get; set; }

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

        // interoperability

        public static implicit operator global::System.Type(Type apexType) => GetSystemType(apexType);

        public static implicit operator Type(global::System.Type systemType) => GetApexType(systemType);

        public static global::System.Type GetSystemType(Type apexType) => Implementation.GetSystemType(apexType);

        public static Type GetApexType(global::System.Type systemType) => Implementation.GetApexType(systemType);

        public bool Equals(Type other) => Self.equals(other);

        public override bool Equals(object obj) => Self.equals(obj);

        public override int GetHashCode() => Self.hashCode();

        public override string ToString() => Self.toString();
    }
}
