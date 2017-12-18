namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionLinkGroupDefinition
    {
        // infrastructure
        public ActionLinkGroupDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinkGroupDefinition));
            }
        }

        // API
        object actionLinks
        {
            get
            {
                return Self.actionLinks;
            }
            set
            {
                Self.actionLinks = value;
            }
        }

        object category
        {
            get
            {
                return Self.category;
            }
            set
            {
                Self.category = value;
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

        object executionsAllowed
        {
            get
            {
                return Self.executionsAllowed;
            }
            set
            {
                Self.executionsAllowed = value;
            }
        }

        object expirationDate
        {
            get
            {
                return Self.expirationDate;
            }
            set
            {
                Self.expirationDate = value;
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

        object modifiedDate
        {
            get
            {
                return Self.modifiedDate;
            }
            set
            {
                Self.modifiedDate = value;
            }
        }

        object templateId
        {
            get
            {
                return Self.templateId;
            }
            set
            {
                Self.templateId = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public ActionLinkGroupDefinition()
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
