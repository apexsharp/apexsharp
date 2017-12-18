namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_DeployMessage.htm#apex_class_Metadata_DeployMessage
    /// </summary>
    public class DeployMessage
    {
        // infrastructure
        public DeployMessage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeployMessage));
            }
        }

        // API
        bool changed
        {
            get
            {
                return Self.changed;
            }
            set
            {
                Self.changed = value;
            }
        }

        int columnNumber
        {
            get
            {
                return Self.columnNumber;
            }
            set
            {
                Self.columnNumber = value;
            }
        }

        string componentType
        {
            get
            {
                return Self.componentType;
            }
            set
            {
                Self.componentType = value;
            }
        }

        bool created
        {
            get
            {
                return Self.created;
            }
            set
            {
                Self.created = value;
            }
        }

        Datetime createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
            }
        }

        bool deleted
        {
            get
            {
                return Self.deleted;
            }
            set
            {
                Self.deleted = value;
            }
        }

        string fileName
        {
            get
            {
                return Self.fileName;
            }
            set
            {
                Self.fileName = value;
            }
        }

        string fullName
        {
            get
            {
                return Self.fullName;
            }
            set
            {
                Self.fullName = value;
            }
        }

        ID id
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

        int lineNumber
        {
            get
            {
                return Self.lineNumber;
            }
            set
            {
                Self.lineNumber = value;
            }
        }

        string problem
        {
            get
            {
                return Self.problem;
            }
            set
            {
                Self.problem = value;
            }
        }

        DeployProblemType problemType
        {
            get
            {
                return Self.problemType;
            }
            set
            {
                Self.problemType = value;
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

        public object clone()
        {
            return Self.clone();
        }

        public DeployMessage()
        {
            Self = Implementation.Constructor();
        }
    }
}
