namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CustomListAudienceCriteriaInput
    {
        // infrastructure
        public CustomListAudienceCriteriaInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CustomListAudienceCriteriaInput));
            }
        }

        // API
        object memberOperationType
        {
            get
            {
                return Self.memberOperationType;
            }
            set
            {
                Self.memberOperationType = value;
            }
        }

        object members
        {
            get
            {
                return Self.members;
            }
            set
            {
                Self.members = value;
            }
        }

        public CustomListAudienceCriteriaInput()
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
