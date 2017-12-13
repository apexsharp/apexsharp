using Apex.System;

namespace Apex.Messaging
{
    public class PushNotificationPayload
    {
        public PushNotificationPayload()
        {
            throw new global::System.NotImplementedException("PushNotificationPayload");
        }

        public static Map<String, object> apple(string alert, string sound, int badgeCount,
            Map<String, object> userData)
        {
            throw new global::System.NotImplementedException("PushNotificationPayload.Apple");
        }

        public static Map<String, object> apple(string alertBody, string actionLocKey, string locKey,
            List<string> locArgs, string launchImage, string sound, int badgeCount, Map<String, object> userData)
        {
            throw new global::System.NotImplementedException("PushNotificationPayload.Apple");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("PushNotificationPayload.Clone");
        }
    }
}