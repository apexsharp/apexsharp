namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecordSummaryList
    {
        // infrastructure
        public RecordSummaryList(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecordSummaryList));
            }
        }

        // API
        object records
        {
            get
            {
                return Self.records;
            }
            set
            {
                Self.records = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public RecordSummaryList()
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
