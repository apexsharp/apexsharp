namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExtensionsCapabilityInput
    {
        // infrastructure
        public ExtensionsCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExtensionsCapabilityInput));
            }
        }

        // API
        object itemsToAdd
        {
            get
            {
                return Self.itemsToAdd;
            }
            set
            {
                Self.itemsToAdd = value;
            }
        }

        object itemsToRemove
        {
            get
            {
                return Self.itemsToRemove;
            }
            set
            {
                Self.itemsToRemove = value;
            }
        }

        public ExtensionsCapabilityInput()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
