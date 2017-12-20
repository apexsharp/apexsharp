namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_QuickAction_QuickActionDefaults.htm#apex_class_QuickAction_QuickActionDefaults
    /// </summary>
    public class QuickActionDefaults
    {
        // infrastructure
        public QuickActionDefaults(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionDefaults));
            }
        }

        // API
        public string getActionName()
        {
            return Self.getActionName();
        }

        public string getActionType()
        {
            return Self.getActionType();
        }

        public ID getContextId()
        {
            return Self.getContextId();
        }

        public SObject getTargetSObject()
        {
            return Self.getTargetSObject();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
