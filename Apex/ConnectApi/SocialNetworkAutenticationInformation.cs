namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialNetworkAutenticationInformation
    {
        // infrastructure
        public SocialNetworkAutenticationInformation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialNetworkAutenticationInformation));
            }
        }

        // API
        object oauthJWT
        {
            get
            {
                return Self.oauthJWT;
            }
            set
            {
                Self.oauthJWT = value;
            }
        }

        object oauthUrl
        {
            get
            {
                return Self.oauthUrl;
            }
            set
            {
                Self.oauthUrl = value;
            }
        }

        public SocialNetworkAutenticationInformation()
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
