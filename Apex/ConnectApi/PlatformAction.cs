namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PlatformAction
    {
        // infrastructure
        public PlatformAction(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PlatformAction));
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

        object apiName
        {
            get
            {
                return Self.apiName;
            }
            set
            {
                Self.apiName = value;
            }
        }

        object confirmationMessage
        {
            get
            {
                return Self.confirmationMessage;
            }
            set
            {
                Self.confirmationMessage = value;
            }
        }

        object executingUser
        {
            get
            {
                return Self.executingUser;
            }
            set
            {
                Self.executingUser = value;
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

        object iconUrl
        {
            get
            {
                return Self.iconUrl;
            }
            set
            {
                Self.iconUrl = value;
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

        object platformActionGroup
        {
            get
            {
                return Self.platformActionGroup;
            }
            set
            {
                Self.platformActionGroup = value;
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

        object subtype
        {
            get
            {
                return Self.subtype;
            }
            set
            {
                Self.subtype = value;
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

        public PlatformAction()
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
