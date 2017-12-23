namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecommendationAudienceCriteriaType
    {
        // infrastructure
        public RecommendationAudienceCriteriaType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecommendationAudienceCriteriaType));
            }
        }

        // API
        object CustomList
        {
            get
            {
                return Self.CustomList;
            }
            set
            {
                Self.CustomList = value;
            }
        }

        object MaxDaysInCommunity
        {
            get
            {
                return Self.MaxDaysInCommunity;
            }
            set
            {
                Self.MaxDaysInCommunity = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<RecommendationAudienceCriteriaType> values()
        {
            return Implementation.values();
        }
    }
}
