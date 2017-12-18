namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ScheduledRecommendationInput
    {
        // infrastructure
        public ScheduledRecommendationInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ScheduledRecommendationInput));
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

        object recommendationDefinitionId
        {
            get
            {
                return Self.recommendationDefinitionId;
            }
            set
            {
                Self.recommendationDefinitionId = value;
            }
        }

        public ScheduledRecommendationInput()
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
