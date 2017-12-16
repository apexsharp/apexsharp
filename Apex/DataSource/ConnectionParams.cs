namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_ConnectionParams.htm#apex_class_DataSource_ConnectionParams
    /// </summary>
    public class ConnectionParams
    {
        // infrastructure
        public ConnectionParams(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConnectionParams));
            }
        }

        // API
        string certificateName
        {
            get
            {
                return Self.certificateName;
            }
            set
            {
                Self.certificateName = value;
            }
        }

        string endpoint
        {
            get
            {
                return Self.endpoint;
            }
            set
            {
                Self.endpoint = value;
            }
        }

        string oauthToken
        {
            get
            {
                return Self.oauthToken;
            }
            set
            {
                Self.oauthToken = value;
            }
        }

        string password
        {
            get
            {
                return Self.password;
            }
            set
            {
                Self.password = value;
            }
        }

        IdentityType principalType
        {
            get
            {
                return Self.principalType;
            }
            set
            {
                Self.principalType = value;
            }
        }

        AuthenticationProtocol protocol
        {
            get
            {
                return Self.protocol;
            }
            set
            {
                Self.protocol = value;
            }
        }

        string repository
        {
            get
            {
                return Self.repository;
            }
            set
            {
                Self.repository = value;
            }
        }

        string username
        {
            get
            {
                return Self.username;
            }
            set
            {
                Self.username = value;
            }
        }
    }
}
