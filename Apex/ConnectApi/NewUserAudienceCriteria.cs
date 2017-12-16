namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NewUserAudienceCriteria
    {
        // infrastructure
        public NewUserAudienceCriteria(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NewUserAudienceCriteria));
            }
        }

        // API
        object maxDaysInCommunity
        {
            get
            {
                return Self.maxDaysInCommunity;
            }
            set
            {
                Self.maxDaysInCommunity = value;
            }
        }

        public NewUserAudienceCriteria()
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
