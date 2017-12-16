namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionLinkDefinition
    {
        // infrastructure
        public ActionLinkDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinkDefinition));
            }
        }

        // API
        object actionUrl
        {
            get
            {
                return Self.actionUrl;
            }
            set
            {
                Self.actionUrl = value;
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

        object excludedUserId
        {
            get
            {
                return Self.excludedUserId;
            }
            set
            {
                Self.excludedUserId = value;
            }
        }

        object groupDefault
        {
            get
            {
                return Self.groupDefault;
            }
            set
            {
                Self.groupDefault = value;
            }
        }

        object headers
        {
            get
            {
                return Self.headers;
            }
            set
            {
                Self.headers = value;
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

        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        object labelKey
        {
            get
            {
                return Self.labelKey;
            }
            set
            {
                Self.labelKey = value;
            }
        }

        object method
        {
            get
            {
                return Self.method;
            }
            set
            {
                Self.method = value;
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

        object requestBody
        {
            get
            {
                return Self.requestBody;
            }
            set
            {
                Self.requestBody = value;
            }
        }

        object requiresConfirmation
        {
            get
            {
                return Self.requiresConfirmation;
            }
            set
            {
                Self.requiresConfirmation = value;
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

        object type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }

        object userId
        {
            get
            {
                return Self.userId;
            }
            set
            {
                Self.userId = value;
            }
        }

        public ActionLinkDefinition()
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
