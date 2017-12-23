namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FolderItemType
    {
        // infrastructure
        public FolderItemType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FolderItemType));
            }
        }

        // API
        object File
        {
            get
            {
                return Self.File;
            }
            set
            {
                Self.File = value;
            }
        }

        object Folder
        {
            get
            {
                return Self.Folder;
            }
            set
            {
                Self.Folder = value;
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

        public static List<FolderItemType> values()
        {
            return Implementation.values();
        }
    }
}
