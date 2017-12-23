namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EntityRecommendation
    {
        // infrastructure
        public EntityRecommendation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EntityRecommendation));
            }
        }

        // API
        object action
        {
            get
            {
                return Self.action;
            }
            set
            {
                Self.action = value;
            }
        }

        object actOnUrl
        {
            get
            {
                return Self.actOnUrl;
            }
            set
            {
                Self.actOnUrl = value;
            }
        }

        object entity
        {
            get
            {
                return Self.entity;
            }
            set
            {
                Self.entity = value;
            }
        }

        public EntityRecommendation()
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
