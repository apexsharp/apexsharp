namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_id.htm#apex_methods_system_id
    /// </summary>
    public class ID
    {
        // infrastructure
        public ID(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ID));
            }
        }

        // API
        public void addError(string errorMsg)
        {
            Self.addError(errorMsg);
        }

        public void addError(string errorMsg, bool escape)
        {
            Self.addError(errorMsg, escape);
        }

        public void addError(Exception exceptionError)
        {
            Self.addError(exceptionError);
        }

        public void addError(Exception exceptionError, bool escape)
        {
            Self.addError(exceptionError, escape);
        }

        public SObjectType getSObjectType()
        {
            return Self.getSObjectType();
        }

        public static ID valueOf(string toID)
        {
            return Implementation.valueOf(toID);
        }

        public bool equals(string o)
        {
            return Self.equals(o);
        }

        public SObjectType getSobjectType()
        {
            return Self.getSobjectType();
        }
    }
}
