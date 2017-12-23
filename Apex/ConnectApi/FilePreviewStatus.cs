namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FilePreviewStatus
    {
        // infrastructure
        public FilePreviewStatus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FilePreviewStatus));
            }
        }

        // API
        object Available
        {
            get
            {
                return Self.Available;
            }
            set
            {
                Self.Available = value;
            }
        }

        object InProgress
        {
            get
            {
                return Self.InProgress;
            }
            set
            {
                Self.InProgress = value;
            }
        }

        object NotAvailable
        {
            get
            {
                return Self.NotAvailable;
            }
            set
            {
                Self.NotAvailable = value;
            }
        }

        object NotScheduled
        {
            get
            {
                return Self.NotScheduled;
            }
            set
            {
                Self.NotScheduled = value;
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

        public static List<FilePreviewStatus> values()
        {
            return Implementation.values();
        }
    }
}
