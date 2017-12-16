namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecommendationAudienceInput
    {
        // infrastructure
        public RecommendationAudienceInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecommendationAudienceInput));
            }
        }

        // API
        object criteria
        {
            get
            {
                return Self.criteria;
            }
            set
            {
                Self.criteria = value;
            }
        }

        object memberOperationType
        {
            get
            {
                return Self.memberOperationType;
            }
            set
            {
                Self.memberOperationType = value;
            }
        }

        object members
        {
            get
            {
                return Self.members;
            }
            set
            {
                Self.members = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        public RecommendationAudienceInput()
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
