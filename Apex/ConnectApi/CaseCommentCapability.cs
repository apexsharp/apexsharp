namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CaseCommentCapability
    {
        // infrastructure
        public CaseCommentCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CaseCommentCapability));
            }
        }

        // API
        object actorType
        {
            get
            {
                return Self.actorType;
            }
            set
            {
                Self.actorType = value;
            }
        }

        object createdBy
        {
            get
            {
                return Self.createdBy;
            }
            set
            {
                Self.createdBy = value;
            }
        }

        object createdDate
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

        object eventType
        {
            get
            {
                return Self.eventType;
            }
            set
            {
                Self.eventType = value;
            }
        }

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

        object published
        {
            get
            {
                return Self.published;
            }
            set
            {
                Self.published = value;
            }
        }

        object text
        {
            get
            {
                return Self.text;
            }
            set
            {
                Self.text = value;
            }
        }

        public CaseCommentCapability()
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
