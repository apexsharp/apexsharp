namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserCapabilities
    {
        // infrastructure
        public UserCapabilities(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserCapabilities));
            }
        }

        // API
        object canChat
        {
            get
            {
                return Self.canChat;
            }
            set
            {
                Self.canChat = value;
            }
        }

        object canDirectMessage
        {
            get
            {
                return Self.canDirectMessage;
            }
            set
            {
                Self.canDirectMessage = value;
            }
        }

        object canEdit
        {
            get
            {
                return Self.canEdit;
            }
            set
            {
                Self.canEdit = value;
            }
        }

        object canFollow
        {
            get
            {
                return Self.canFollow;
            }
            set
            {
                Self.canFollow = value;
            }
        }

        object canViewFeed
        {
            get
            {
                return Self.canViewFeed;
            }
            set
            {
                Self.canViewFeed = value;
            }
        }

        object canViewFullProfile
        {
            get
            {
                return Self.canViewFullProfile;
            }
            set
            {
                Self.canViewFullProfile = value;
            }
        }

        object isModerator
        {
            get
            {
                return Self.isModerator;
            }
            set
            {
                Self.isModerator = value;
            }
        }

        public UserCapabilities()
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
