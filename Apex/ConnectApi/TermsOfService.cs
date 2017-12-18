namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TermsOfService
    {
        // infrastructure
        public TermsOfService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TermsOfService));
            }
        }

        // API
        object acceptingUserId
        {
            get
            {
                return Self.acceptingUserId;
            }
            set
            {
                Self.acceptingUserId = value;
            }
        }

        object termsOfServiceUrl
        {
            get
            {
                return Self.termsOfServiceUrl;
            }
            set
            {
                Self.termsOfServiceUrl = value;
            }
        }

        public TermsOfService()
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
