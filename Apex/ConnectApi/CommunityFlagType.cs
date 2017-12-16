namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommunityFlagType
    {
        // infrastructure
        public CommunityFlagType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommunityFlagType));
            }
        }

        // API
        object FlagAsInappropriate
        {
            get
            {
                return Self.FlagAsInappropriate;
            }
            set
            {
                Self.FlagAsInappropriate = value;
            }
        }

        object FlagAsSpam
        {
            get
            {
                return Self.FlagAsSpam;
            }
            set
            {
                Self.FlagAsSpam = value;
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

        public static List<CommunityFlagType> values()
        {
            return Implementation.values();
        }
    }
}
