namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActionLinkDefinitionInput
    {
        // infrastructure
        public ActionLinkDefinitionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActionLinkDefinitionInput));
            }
        }

        // API
        object actionType
        {
            get
            {
                return Self.actionType;
            }
            set
            {
                Self.actionType = value;
            }
        }

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

        public ActionLinkDefinitionInput()
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
