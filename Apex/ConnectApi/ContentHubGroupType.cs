namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubGroupType
    {
        // infrastructure
        public ContentHubGroupType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubGroupType));
            }
        }

        // API
        object Everybody
        {
            get
            {
                return Self.Everybody;
            }
            set
            {
                Self.Everybody = value;
            }
        }

        object EverybodyInDomain
        {
            get
            {
                return Self.EverybodyInDomain;
            }
            set
            {
                Self.EverybodyInDomain = value;
            }
        }

        object Unknown
        {
            get
            {
                return Self.Unknown;
            }
            set
            {
                Self.Unknown = value;
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

        public static List<ContentHubGroupType> values()
        {
            return Implementation.values();
        }
    }
}
