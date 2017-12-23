namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class KnowledgeMigration
    {
        // infrastructure
        public KnowledgeMigration(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(KnowledgeMigration));
            }
        }

        // API
        object migrationJobId
        {
            get
            {
                return Self.migrationJobId;
            }
            set
            {
                Self.migrationJobId = value;
            }
        }

        object migrationStatus
        {
            get
            {
                return Self.migrationStatus;
            }
            set
            {
                Self.migrationStatus = value;
            }
        }

        public KnowledgeMigration()
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
