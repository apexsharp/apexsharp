namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DirectMessageMemberActivity
    {
        // infrastructure
        public DirectMessageMemberActivity(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DirectMessageMemberActivity));
            }
        }

        // API
        object activityDate
        {
            get
            {
                return Self.activityDate;
            }
            set
            {
                Self.activityDate = value;
            }
        }

        object actor
        {
            get
            {
                return Self.actor;
            }
            set
            {
                Self.actor = value;
            }
        }

        object membersAdded
        {
            get
            {
                return Self.membersAdded;
            }
            set
            {
                Self.membersAdded = value;
            }
        }

        object membersRemoved
        {
            get
            {
                return Self.membersRemoved;
            }
            set
            {
                Self.membersRemoved = value;
            }
        }

        public DirectMessageMemberActivity()
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
