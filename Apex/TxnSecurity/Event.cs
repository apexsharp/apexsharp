namespace Apex.TxnSecurity
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_TxnSecurity_Event.htm#apex_class_TxnSecurity_Event
    /// </summary>
    public class Event
    {
        // infrastructure
        public Event(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Event));
            }
        }

        // API
        public Event()
        {
            Self = Implementation.Constructor();
        }

        string action
        {
            get
            {
                return Self.action;
            }
            set
            {
                Self.action = value;
            }
        }

        Map<string, string> data
        {
            get
            {
                return Self.data;
            }
            set
            {
                Self.data = value;
            }
        }

        string entityId
        {
            get
            {
                return Self.entityId;
            }
            set
            {
                Self.entityId = value;
            }
        }

        string entityName
        {
            get
            {
                return Self.entityName;
            }
            set
            {
                Self.entityName = value;
            }
        }

        string organizationId
        {
            get
            {
                return Self.organizationId;
            }
            set
            {
                Self.organizationId = value;
            }
        }

        string resourceType
        {
            get
            {
                return Self.resourceType;
            }
            set
            {
                Self.resourceType = value;
            }
        }

        Datetime timeStamp
        {
            get
            {
                return Self.timeStamp;
            }
            set
            {
                Self.timeStamp = value;
            }
        }

        string userId
        {
            get
            {
                return Self.userId;
            }
            set
            {
                Self.userId = value;
            }
        }

        public Event(string organizationId, string userId, string entityName, string action, string resourceType, string entityId, Datetime timeStamp, Map<string, string> data)
        {
            Self = Implementation.Constructor(organizationId, userId, entityName, action, resourceType, entityId, timeStamp, data);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
