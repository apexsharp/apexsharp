using Apex.System;

namespace Apex.TxnSecurity
{
    public class Event
    {
        public Event(string organizationId, string userId, string entityName, string action, string resourceType,
            string entityId, DateTime timeStamp, Map<String, String> data)
        {
            throw new global::System.NotImplementedException("Event");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Event.Clone");
        }
    }
}