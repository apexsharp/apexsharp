namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecordViewSection
    {
        // infrastructure
        public RecordViewSection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecordViewSection));
            }
        }

        // API
        object columnCount
        {
            get
            {
                return Self.columnCount;
            }
            set
            {
                Self.columnCount = value;
            }
        }

        object columnOrder
        {
            get
            {
                return Self.columnOrder;
            }
            set
            {
                Self.columnOrder = value;
            }
        }

        object fields
        {
            get
            {
                return Self.fields;
            }
            set
            {
                Self.fields = value;
            }
        }

        object heading
        {
            get
            {
                return Self.heading;
            }
            set
            {
                Self.heading = value;
            }
        }

        object isCollapsible
        {
            get
            {
                return Self.isCollapsible;
            }
            set
            {
                Self.isCollapsible = value;
            }
        }

        public RecordViewSection()
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
