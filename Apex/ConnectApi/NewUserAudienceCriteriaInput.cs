namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NewUserAudienceCriteriaInput
    {
        // infrastructure
        public NewUserAudienceCriteriaInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NewUserAudienceCriteriaInput));
            }
        }

        // API
        object value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }

        public NewUserAudienceCriteriaInput()
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
