namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubDirectoryEntryType
    {
        // infrastructure
        public ContentHubDirectoryEntryType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubDirectoryEntryType));
            }
        }

        // API
        object GroupEntry
        {
            get
            {
                return Self.GroupEntry;
            }
            set
            {
                Self.GroupEntry = value;
            }
        }

        object UserEntry
        {
            get
            {
                return Self.UserEntry;
            }
            set
            {
                Self.UserEntry = value;
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

        public static List<ContentHubDirectoryEntryType> values()
        {
            return Implementation.values();
        }
    }
}
