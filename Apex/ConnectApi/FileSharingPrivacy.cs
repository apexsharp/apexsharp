namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FileSharingPrivacy
    {
        // infrastructure
        public FileSharingPrivacy(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FileSharingPrivacy));
            }
        }

        // API
        object None
        {
            get
            {
                return Self.None;
            }
            set
            {
                Self.None = value;
            }
        }

        object PrivateOnRecords
        {
            get
            {
                return Self.PrivateOnRecords;
            }
            set
            {
                Self.PrivateOnRecords = value;
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

        public static List<FileSharingPrivacy> values()
        {
            return Implementation.values();
        }
    }
}
