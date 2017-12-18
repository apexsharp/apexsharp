namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MoreChangesSegment
    {
        // infrastructure
        public MoreChangesSegment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MoreChangesSegment));
            }
        }

        // API
        object moreChanges
        {
            get
            {
                return Self.moreChanges;
            }
            set
            {
                Self.moreChanges = value;
            }
        }

        object moreChangesCount
        {
            get
            {
                return Self.moreChangesCount;
            }
            set
            {
                Self.moreChangesCount = value;
            }
        }

        public MoreChangesSegment()
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
