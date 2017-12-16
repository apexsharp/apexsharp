namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MentionValidations
    {
        // infrastructure
        public MentionValidations(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MentionValidations));
            }
        }

        // API
        object hasErrors
        {
            get
            {
                return Self.hasErrors;
            }
            set
            {
                Self.hasErrors = value;
            }
        }

        object mentionValidations
        {
            get
            {
                return Self.mentionValidations;
            }
            set
            {
                Self.mentionValidations = value;
            }
        }

        public MentionValidations()
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

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
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
