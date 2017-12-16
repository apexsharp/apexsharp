namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ScheduledRecommendation
    {
        // infrastructure
        public ScheduledRecommendation(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ScheduledRecommendation));
            }
        }

        // API
        object channel
        {
            get
            {
                return Self.channel;
            }
            set
            {
                Self.channel = value;
            }
        }

        object enabled
        {
            get
            {
                return Self.enabled;
            }
            set
            {
                Self.enabled = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object rank
        {
            get
            {
                return Self.rank;
            }
            set
            {
                Self.rank = value;
            }
        }

        object recommendationAudienceId
        {
            get
            {
                return Self.recommendationAudienceId;
            }
            set
            {
                Self.recommendationAudienceId = value;
            }
        }

        object recommendationDefinitionRepresentation
        {
            get
            {
                return Self.recommendationDefinitionRepresentation;
            }
            set
            {
                Self.recommendationDefinitionRepresentation = value;
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

        public ScheduledRecommendation()
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
