namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudInternalCompany
    {
        // infrastructure
        public DatacloudInternalCompany(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudInternalCompany));
            }
        }

        // API
        object domesticUltimateDuns
        {
            get
            {
                return Self.domesticUltimateDuns;
            }
            set
            {
                Self.domesticUltimateDuns = value;
            }
        }

        object externalRepresentation
        {
            get
            {
                return Self.externalRepresentation;
            }
            set
            {
                Self.externalRepresentation = value;
            }
        }

        object globalUltimateDuns
        {
            get
            {
                return Self.globalUltimateDuns;
            }
            set
            {
                Self.globalUltimateDuns = value;
            }
        }

        object isInCrm
        {
            get
            {
                return Self.isInCrm;
            }
            set
            {
                Self.isInCrm = value;
            }
        }

        object isMarketable
        {
            get
            {
                return Self.isMarketable;
            }
            set
            {
                Self.isMarketable = value;
            }
        }

        object parentDuns
        {
            get
            {
                return Self.parentDuns;
            }
            set
            {
                Self.parentDuns = value;
            }
        }

        public DatacloudInternalCompany()
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

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
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
