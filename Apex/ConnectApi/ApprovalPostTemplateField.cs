namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ApprovalPostTemplateField
    {
        // infrastructure
        public ApprovalPostTemplateField(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ApprovalPostTemplateField));
            }
        }

        // API
        object displayName
        {
            get
            {
                return Self.displayName;
            }
            set
            {
                Self.displayName = value;
            }
        }

        object displayValue
        {
            get
            {
                return Self.displayValue;
            }
            set
            {
                Self.displayValue = value;
            }
        }

        object record
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

        public ApprovalPostTemplateField()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
