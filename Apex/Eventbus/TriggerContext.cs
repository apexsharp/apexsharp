namespace Apex.EventBus
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_eventbus_TriggerContext.htm#apex_class_eventbus_TriggerContext
    /// </summary>
    public class TriggerContext
    {
        // infrastructure
        public TriggerContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TriggerContext));
            }
        }

        // API
        string lastError
        {
            get
            {
                return Self.lastError;
            }
        }

        int retries
        {
            get
            {
                return Self.retries;
            }
        }

        public static TriggerContext currentContext()
        {
            return Implementation.currentContext();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
