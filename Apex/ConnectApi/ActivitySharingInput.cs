namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActivitySharingInput
    {
        // infrastructure
        public ActivitySharingInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActivitySharingInput));
            }
        }

        // API
        object groupsToShareWith
        {
            get
            {
                return Self.groupsToShareWith;
            }
            set
            {
                Self.groupsToShareWith = value;
            }
        }

        object sharingType
        {
            get
            {
                return Self.sharingType;
            }
            set
            {
                Self.sharingType = value;
            }
        }

        public ActivitySharingInput()
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
