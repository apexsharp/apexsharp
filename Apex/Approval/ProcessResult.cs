namespace Apex.Approval
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ProcessResult.htm#apex_ProcessResult
    /// </summary>
    public class ProcessResult
    {
        // infrastructure
        public ProcessResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProcessResult));
            }
        }

        // API
        public string getEntityId()
        {
            return Self.getEntityId();
        }

        public Error[] getErrors()
        {
            return Self.getErrors();
        }

        public string getInstanceId()
        {
            return Self.getInstanceId();
        }

        public string getInstanceStatus()
        {
            return Self.getInstanceStatus();
        }

        public ID[] getNewWorkitemIds()
        {
            return Self.getNewWorkitemIds();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        List<ID> actorIds
        {
            get
            {
                return Self.actorIds;
            }
            set
            {
                Self.actorIds = value;
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

        List<Error> errors
        {
            get
            {
                return Self.errors;
            }
            set
            {
                Self.errors = value;
            }
        }

        string instanceId
        {
            get
            {
                return Self.instanceId;
            }
            set
            {
                Self.instanceId = value;
            }
        }

        string instanceStatus
        {
            get
            {
                return Self.instanceStatus;
            }
            set
            {
                Self.instanceStatus = value;
            }
        }

        List<ID> newWorkitemIds
        {
            get
            {
                return Self.newWorkitemIds;
            }
            set
            {
                Self.newWorkitemIds = value;
            }
        }

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }

        public List<ID> getActorIds()
        {
            return Self.getActorIds();
        }
    }
}
