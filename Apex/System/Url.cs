namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Url
    {
        // infrastructure
        public Url(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Url));
            }
        }

        // API
        public Url(string spec)
        {
            Self = Implementation.Constructor(spec);
        }

        public Url(string protocol, string host, int port, string file)
        {
            Self = Implementation.Constructor(protocol, host, port, file);
        }

        public Url(string protocol, string host, string file)
        {
            Self = Implementation.Constructor(protocol, host, file);
        }

        public Url(Url context, string spec)
        {
            Self = Implementation.Constructor(context, spec);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getAuthority()
        {
            return Self.getAuthority();
        }

        public static Url getCurrentRequestUrl()
        {
            return Implementation.getCurrentRequestUrl();
        }

        public int getDefaultPort()
        {
            return Self.getDefaultPort();
        }

        public string getFile()
        {
            return Self.getFile();
        }

        public static string getFileFieldURL(string objectId, string fieldName)
        {
            return Implementation.getFileFieldURL(objectId, fieldName);
        }

        public string getHost()
        {
            return Self.getHost();
        }

        public string getPath()
        {
            return Self.getPath();
        }

        public int getPort()
        {
            return Self.getPort();
        }

        public string getProtocol()
        {
            return Self.getProtocol();
        }

        public string getQuery()
        {
            return Self.getQuery();
        }

        public string getRef()
        {
            return Self.getRef();
        }

        public static Url getSalesforceBaseUrl()
        {
            return Implementation.getSalesforceBaseUrl();
        }

        public string getUserInfo()
        {
            return Self.getUserInfo();
        }

        public bool sameFile(Url other)
        {
            return Self.sameFile(other);
        }

        public string toExternalForm()
        {
            return Self.toExternalForm();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
