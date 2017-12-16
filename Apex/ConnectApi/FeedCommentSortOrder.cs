namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedCommentSortOrder
    {
        // infrastructure
        public FeedCommentSortOrder(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedCommentSortOrder));
            }
        }

        // API
        object CreatedDateLatestAsc
        {
            get
            {
                return Self.CreatedDateLatestAsc;
            }
            set
            {
                Self.CreatedDateLatestAsc = value;
            }
        }

        object Relevance
        {
            get
            {
                return Self.Relevance;
            }
            set
            {
                Self.Relevance = value;
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

        public static List<FeedCommentSortOrder> values()
        {
            return Implementation.values();
        }
    }
}
