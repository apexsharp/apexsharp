namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommunityFlagReasonType
    {
        // infrastructure
        public CommunityFlagReasonType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommunityFlagReasonType));
            }
        }

        // API
        object FlaggedByRule
        {
            get
            {
                return Self.FlaggedByRule;
            }
            set
            {
                Self.FlaggedByRule = value;
            }
        }

        object FlaggedBySystem
        {
            get
            {
                return Self.FlaggedBySystem;
            }
            set
            {
                Self.FlaggedBySystem = value;
            }
        }

        object FlaggedByUserAsInappropriate
        {
            get
            {
                return Self.FlaggedByUserAsInappropriate;
            }
            set
            {
                Self.FlaggedByUserAsInappropriate = value;
            }
        }

        object FlaggedByUserAsSpam
        {
            get
            {
                return Self.FlaggedByUserAsSpam;
            }
            set
            {
                Self.FlaggedByUserAsSpam = value;
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

        public static List<CommunityFlagReasonType> values()
        {
            return Implementation.values();
        }
    }
}
