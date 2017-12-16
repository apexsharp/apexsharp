namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_eventbus.htm#apex_class_System_eventbus
    /// </summary>
    public class EventBus
    {
        // infrastructure
        public EventBus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EventBus));
            }
        }

        // API
        public static SaveResult publish(SObject @event)
        {
            return Implementation.publish(@event);
        }

        public static List<SaveResult> publish(List<SObject> events)
        {
            return Implementation.publish(events);
        }
    }
}
