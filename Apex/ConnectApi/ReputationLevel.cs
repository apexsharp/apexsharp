namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReputationLevel
    {
        // infrastructure
        public ReputationLevel(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReputationLevel));
            }
        }

        // API
        object levelImageUrl
        {
            get
            {
                return Self.levelImageUrl;
            }
            set
            {
                Self.levelImageUrl = value;
            }
        }

        object levelName
        {
            get
            {
                return Self.levelName;
            }
            set
            {
                Self.levelName = value;
            }
        }

        object levelNumber
        {
            get
            {
                return Self.levelNumber;
            }
            set
            {
                Self.levelNumber = value;
            }
        }

        public ReputationLevel()
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
