namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudImport
    {
        // infrastructure
        public DatacloudImport(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudImport));
            }
        }

        // API
        object duplicatesSkippedCount
        {
            get
            {
                return Self.duplicatesSkippedCount;
            }
            set
            {
                Self.duplicatesSkippedCount = value;
            }
        }

        object errorCount
        {
            get
            {
                return Self.errorCount;
            }
            set
            {
                Self.errorCount = value;
            }
        }

        object errorMessageDescriptionUrl
        {
            get
            {
                return Self.errorMessageDescriptionUrl;
            }
            set
            {
                Self.errorMessageDescriptionUrl = value;
            }
        }

        object importStatus
        {
            get
            {
                return Self.importStatus;
            }
            set
            {
                Self.importStatus = value;
            }
        }

        object orgAllowsDuplicates
        {
            get
            {
                return Self.orgAllowsDuplicates;
            }
            set
            {
                Self.orgAllowsDuplicates = value;
            }
        }

        object successCount
        {
            get
            {
                return Self.successCount;
            }
            set
            {
                Self.successCount = value;
            }
        }

        public DatacloudImport()
        {
            Implementation.Constructor();
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
