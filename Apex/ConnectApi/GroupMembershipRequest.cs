namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class GroupMembershipRequest
    {
        // infrastructure
        public GroupMembershipRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupMembershipRequest));
            }
        }

        // API
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

        object lastUpdateDate
        {
            get
            {
                return Self.lastUpdateDate;
            }
            set
            {
                Self.lastUpdateDate = value;
            }
        }

        object requestedGroup
        {
            get
            {
                return Self.requestedGroup;
            }
            set
            {
                Self.requestedGroup = value;
            }
        }

        object responseMessage
        {
            get
            {
                return Self.responseMessage;
            }
            set
            {
                Self.responseMessage = value;
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

        object user
        {
            get
            {
                return Self.user;
            }
            set
            {
                Self.user = value;
            }
        }

        public GroupMembershipRequest()
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
