namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubRepositoryAuthentication
    {
        // infrastructure
        public ContentHubRepositoryAuthentication(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubRepositoryAuthentication));
            }
        }

        // API
        object authFlowUrl
        {
            get
            {
                return Self.authFlowUrl;
            }
            set
            {
                Self.authFlowUrl = value;
            }
        }

        object authProtocol
        {
            get
            {
                return Self.authProtocol;
            }
            set
            {
                Self.authProtocol = value;
            }
        }

        object userHasAuthSettings
        {
            get
            {
                return Self.userHasAuthSettings;
            }
            set
            {
                Self.userHasAuthSettings = value;
            }
        }

        public ContentHubRepositoryAuthentication()
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
