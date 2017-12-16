namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AssociatedActionsCapabilityInput
    {
        // infrastructure
        public AssociatedActionsCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AssociatedActionsCapabilityInput));
            }
        }

        // API
        object actionLinkGroupIds
        {
            get
            {
                return Self.actionLinkGroupIds;
            }
            set
            {
                Self.actionLinkGroupIds = value;
            }
        }

        public AssociatedActionsCapabilityInput()
        {
            Implementation.Constructor();
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
