namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_quickaction_quickactionrequest.htm#apex_class_quickaction_quickactionrequest
    /// </summary>
    public class QuickActionRequest
    {
        // infrastructure
        public QuickActionRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionRequest));
            }
        }

        // API
        public QuickActionRequest()
        {
            Implementation.Constructor();
        }

        public ID getContextId()
        {
            return Self.getContextId();
        }

        public string getQuickActionName()
        {
            return Self.getQuickActionName();
        }

        public SObject getRecord()
        {
            return Self.getRecord();
        }

        public void setContextId(ID contextId)
        {
            Self.setContextId(contextId);
        }

        public void setQuickActionName(string name)
        {
            Self.setQuickActionName(name);
        }

        public void setRecord(SObject record)
        {
            Self.setRecord(record);
        }

        ID contextId
        {
            get
            {
                return Self.contextId;
            }
            set
            {
                Self.contextId = value;
            }
        }

        string quickActionName
        {
            get
            {
                return Self.quickActionName;
            }
            set
            {
                Self.quickActionName = value;
            }
        }

        SObject record
        {
            get
            {
                return Self.record;
            }
            set
            {
                Self.record = value;
            }
        }
    }
}
