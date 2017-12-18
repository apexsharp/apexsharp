namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ModerationFlags
    {
        // infrastructure
        public ModerationFlags(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ModerationFlags));
            }
        }

        // API
        object flagCount
        {
            get
            {
                return Self.flagCount;
            }
            set
            {
                Self.flagCount = value;
            }
        }

        object flagCountByReason
        {
            get
            {
                return Self.flagCountByReason;
            }
            set
            {
                Self.flagCountByReason = value;
            }
        }

        object flaggedByMe
        {
            get
            {
                return Self.flaggedByMe;
            }
            set
            {
                Self.flaggedByMe = value;
            }
        }

        object flags
        {
            get
            {
                return Self.flags;
            }
            set
            {
                Self.flags = value;
            }
        }

        public ModerationFlags()
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
