namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FileSharingOption
    {
        // infrastructure
        public FileSharingOption(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FileSharingOption));
            }
        }

        // API
        object Allowed
        {
            get
            {
                return Self.Allowed;
            }
            set
            {
                Self.Allowed = value;
            }
        }

        object Restricted
        {
            get
            {
                return Self.Restricted;
            }
            set
            {
                Self.Restricted = value;
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

        public static List<FileSharingOption> values()
        {
            return Implementation.values();
        }
    }
}
