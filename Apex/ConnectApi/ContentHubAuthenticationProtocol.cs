namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubAuthenticationProtocol
    {
        // infrastructure
        public ContentHubAuthenticationProtocol(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubAuthenticationProtocol));
            }
        }

        // API
        object NoAuthentication
        {
            get
            {
                return Self.NoAuthentication;
            }
            set
            {
                Self.NoAuthentication = value;
            }
        }

        object Oauth
        {
            get
            {
                return Self.Oauth;
            }
            set
            {
                Self.Oauth = value;
            }
        }

        object Password
        {
            get
            {
                return Self.Password;
            }
            set
            {
                Self.Password = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<ContentHubAuthenticationProtocol> values()
        {
            return Implementation.values();
        }
    }
}
