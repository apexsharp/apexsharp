namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActivitySharingType
    {
        // infrastructure
        public ActivitySharingType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActivitySharingType));
            }
        }

        // API
        object Everyone
        {
            get
            {
                return Self.Everyone;
            }
            set
            {
                Self.Everyone = value;
            }
        }

        object MyGroups
        {
            get
            {
                return Self.MyGroups;
            }
            set
            {
                Self.MyGroups = value;
            }
        }

        object OnlyMe
        {
            get
            {
                return Self.OnlyMe;
            }
            set
            {
                Self.OnlyMe = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<ActivitySharingType> values()
        {
            return Implementation.values();
        }
    }
}
