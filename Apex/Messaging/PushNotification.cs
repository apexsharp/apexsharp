namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PushNotification
    {
        // infrastructure
        public PushNotification(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PushNotification));
            }
        }

        // API
        public PushNotification()
        {
            Self = Implementation.Constructor();
        }

        public PushNotification(Map<string, object> payload)
        {
            Self = Implementation.Constructor(payload);
        }

        public object clone()
        {
            return Self.clone();
        }

        public void send(string application, Set<string> users)
        {
            Self.send(application, users);
        }

        public void setPayload(Map<string, object> payload)
        {
            Self.setPayload(payload);
        }

        public void setTtl(int ttl)
        {
            Self.setTtl(ttl);
        }
    }
}
