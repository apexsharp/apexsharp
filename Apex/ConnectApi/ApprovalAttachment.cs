namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ApprovalAttachment
    {
        // infrastructure
        public ApprovalAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ApprovalAttachment));
            }
        }

        // API
        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object postTemplateFields
        {
            get
            {
                return Self.postTemplateFields;
            }
            set
            {
                Self.postTemplateFields = value;
            }
        }

        object processInstanceStepId
        {
            get
            {
                return Self.processInstanceStepId;
            }
            set
            {
                Self.processInstanceStepId = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
            }
        }

        public ApprovalAttachment()
        {
            Implementation.Constructor();
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
