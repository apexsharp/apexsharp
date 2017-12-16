namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterGroupDetail
    {
        // infrastructure
        public ChatterGroupDetail(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterGroupDetail));
            }
        }

        // API
        object fileCount
        {
            get
            {
                return Self.fileCount;
            }
            set
            {
                Self.fileCount = value;
            }
        }

        object information
        {
            get
            {
                return Self.information;
            }
            set
            {
                Self.information = value;
            }
        }

        object pendingRequests
        {
            get
            {
                return Self.pendingRequests;
            }
            set
            {
                Self.pendingRequests = value;
            }
        }

        public ChatterGroupDetail()
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
