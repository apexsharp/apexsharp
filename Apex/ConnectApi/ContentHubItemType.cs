namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubItemType
    {
        // infrastructure
        public ContentHubItemType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubItemType));
            }
        }

        // API
        object Any
        {
            get
            {
                return Self.Any;
            }
            set
            {
                Self.Any = value;
            }
        }

        object FilesOnly
        {
            get
            {
                return Self.FilesOnly;
            }
            set
            {
                Self.FilesOnly = value;
            }
        }

        object FoldersOnly
        {
            get
            {
                return Self.FoldersOnly;
            }
            set
            {
                Self.FoldersOnly = value;
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

        public static List<ContentHubItemType> values()
        {
            return Implementation.values();
        }
    }
}
