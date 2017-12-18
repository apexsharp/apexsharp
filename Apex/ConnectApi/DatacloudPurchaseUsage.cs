namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudPurchaseUsage
    {
        // infrastructure
        public DatacloudPurchaseUsage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudPurchaseUsage));
            }
        }

        // API
        object listpoolCreditsAvailable
        {
            get
            {
                return Self.listpoolCreditsAvailable;
            }
            set
            {
                Self.listpoolCreditsAvailable = value;
            }
        }

        object listpoolCreditsUsed
        {
            get
            {
                return Self.listpoolCreditsUsed;
            }
            set
            {
                Self.listpoolCreditsUsed = value;
            }
        }

        object monthlyCreditsAvailable
        {
            get
            {
                return Self.monthlyCreditsAvailable;
            }
            set
            {
                Self.monthlyCreditsAvailable = value;
            }
        }

        object monthlyCreditsUsed
        {
            get
            {
                return Self.monthlyCreditsUsed;
            }
            set
            {
                Self.monthlyCreditsUsed = value;
            }
        }

        public DatacloudPurchaseUsage()
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
