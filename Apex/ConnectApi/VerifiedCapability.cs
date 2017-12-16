namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VerifiedCapability
    {
        // infrastructure
        public VerifiedCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VerifiedCapability));
            }
        }

        // API
        object isVerifiableByMe
        {
            get
            {
                return Self.isVerifiableByMe;
            }
            set
            {
                Self.isVerifiableByMe = value;
            }
        }

        object isVerified
        {
            get
            {
                return Self.isVerified;
            }
            set
            {
                Self.isVerified = value;
            }
        }

        object lastVerifiedByUser
        {
            get
            {
                return Self.lastVerifiedByUser;
            }
            set
            {
                Self.lastVerifiedByUser = value;
            }
        }

        object lastVerifiedDate
        {
            get
            {
                return Self.lastVerifiedDate;
            }
            set
            {
                Self.lastVerifiedDate = value;
            }
        }

        public VerifiedCapability()
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
