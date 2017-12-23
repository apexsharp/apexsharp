namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudImportStatusType
    {
        // infrastructure
        public DatacloudImportStatusType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudImportStatusType));
            }
        }

        // API
        object Duplicate
        {
            get
            {
                return Self.Duplicate;
            }
            set
            {
                Self.Duplicate = value;
            }
        }

        object Error
        {
            get
            {
                return Self.Error;
            }
            set
            {
                Self.Error = value;
            }
        }

        object Success
        {
            get
            {
                return Self.Success;
            }
            set
            {
                Self.Success = value;
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

        public static List<DatacloudImportStatusType> values()
        {
            return Implementation.values();
        }
    }
}
