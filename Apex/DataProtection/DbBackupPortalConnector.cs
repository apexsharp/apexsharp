namespace Apex.DataProtection
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DbBackupPortalConnector
    {
        // infrastructure
        public DbBackupPortalConnector(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DbBackupPortalConnector));
            }
        }

        // API
        public DbBackupPortalConnector()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public void getInstanceList(List<string> instancesToFill)
        {
            Self.getInstanceList(instancesToFill);
        }

        public string getRmanStats(List<string> instanceNames, string userMessage, long timeoutMilli)
        {
            return Self.getRmanStats(instanceNames, userMessage, timeoutMilli);
        }

        public string getRmanStats(List<string> instanceNames, string userMessage, long timeoutMilli, string soapEndPoint)
        {
            return Self.getRmanStats(instanceNames, userMessage, timeoutMilli, soapEndPoint);
        }
    }
}
