namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudOrderInput
    {
        // infrastructure
        public DatacloudOrderInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudOrderInput));
            }
        }

        // API
        object companyIds
        {
            get
            {
                return Self.companyIds;
            }
            set
            {
                Self.companyIds = value;
            }
        }

        object contactIds
        {
            get
            {
                return Self.contactIds;
            }
            set
            {
                Self.contactIds = value;
            }
        }

        object userType
        {
            get
            {
                return Self.userType;
            }
            set
            {
                Self.userType = value;
            }
        }

        public DatacloudOrderInput()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
