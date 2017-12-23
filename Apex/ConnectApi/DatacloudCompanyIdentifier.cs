namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudCompanyIdentifier
    {
        // infrastructure
        public DatacloudCompanyIdentifier(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudCompanyIdentifier));
            }
        }

        // API
        object AccountId
        {
            get
            {
                return Self.AccountId;
            }
            set
            {
                Self.AccountId = value;
            }
        }

        object DatacloudCompanyId
        {
            get
            {
                return Self.DatacloudCompanyId;
            }
            set
            {
                Self.DatacloudCompanyId = value;
            }
        }

        object Duns
        {
            get
            {
                return Self.Duns;
            }
            set
            {
                Self.Duns = value;
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

        public static List<DatacloudCompanyIdentifier> values()
        {
            return Implementation.values();
        }
    }
}
