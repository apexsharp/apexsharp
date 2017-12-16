namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ArticleTopicJobType
    {
        // infrastructure
        public ArticleTopicJobType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ArticleTopicJobType));
            }
        }

        // API
        object AssignTopicsToArticles
        {
            get
            {
                return Self.AssignTopicsToArticles;
            }
            set
            {
                Self.AssignTopicsToArticles = value;
            }
        }

        object UnassignTopicsFromArticles
        {
            get
            {
                return Self.UnassignTopicsFromArticles;
            }
            set
            {
                Self.UnassignTopicsFromArticles = value;
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

        public static List<ArticleTopicJobType> values()
        {
            return Implementation.values();
        }
    }
}
