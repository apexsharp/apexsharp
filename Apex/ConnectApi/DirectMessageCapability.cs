namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DirectMessageCapability
    {
        // infrastructure
        public DirectMessageCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DirectMessageCapability));
            }
        }

        // API
        object memberChanges
        {
            get
            {
                return Self.memberChanges;
            }
            set
            {
                Self.memberChanges = value;
            }
        }

        object members
        {
            get
            {
                return Self.members;
            }
            set
            {
                Self.members = value;
            }
        }

        object originalMembers
        {
            get
            {
                return Self.originalMembers;
            }
            set
            {
                Self.originalMembers = value;
            }
        }

        object subject
        {
            get
            {
                return Self.subject;
            }
            set
            {
                Self.subject = value;
            }
        }

        public DirectMessageCapability()
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
