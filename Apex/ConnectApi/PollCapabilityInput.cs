namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PollCapabilityInput
    {
        // infrastructure
        public PollCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PollCapabilityInput));
            }
        }

        // API
        object choices
        {
            get
            {
                return Self.choices;
            }
            set
            {
                Self.choices = value;
            }
        }

        object myChoiceId
        {
            get
            {
                return Self.myChoiceId;
            }
            set
            {
                Self.myChoiceId = value;
            }
        }

        public PollCapabilityInput()
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
