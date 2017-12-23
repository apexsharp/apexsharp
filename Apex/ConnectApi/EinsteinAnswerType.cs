namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EinsteinAnswerType
    {
        // infrastructure
        public EinsteinAnswerType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EinsteinAnswerType));
            }
        }

        // API
        object ChatterPost
        {
            get
            {
                return Self.ChatterPost;
            }
            set
            {
                Self.ChatterPost = value;
            }
        }

        object KnowledgeArticle
        {
            get
            {
                return Self.KnowledgeArticle;
            }
            set
            {
                Self.KnowledgeArticle = value;
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

        public static List<EinsteinAnswerType> values()
        {
            return Implementation.values();
        }
    }
}
