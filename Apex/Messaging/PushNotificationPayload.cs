namespace Apex.Messaging
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PushNotificationPayload
    {
        // infrastructure
        public PushNotificationPayload(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PushNotificationPayload));
            }
        }

        // API
        public PushNotificationPayload()
        {
            Self = Implementation.Constructor();
        }

        public static Map<string, object> apple(string alert, string sound, int badgeCount, Map<string, object> userData)
        {
            return Implementation.apple(alert, sound, badgeCount, userData);
        }

        public static Map<string, object> apple(string alertBody, string actionLocKey, string locKey, List<string> locArgs, string launchImage, string sound, int badgeCount, Map<string, object> userData)
        {
            return Implementation.apple(alertBody, actionLocKey, locKey, locArgs, launchImage, sound, badgeCount, userData);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
