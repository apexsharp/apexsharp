namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedEntityStatus
    {
        // infrastructure
        public FeedEntityStatus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedEntityStatus));
            }
        }

        // API
        object PendingReview
        {
            get
            {
                return Self.PendingReview;
            }
            set
            {
                Self.PendingReview = value;
            }
        }

        object Published
        {
            get
            {
                return Self.Published;
            }
            set
            {
                Self.Published = value;
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

        public static List<FeedEntityStatus> values()
        {
            return Implementation.values();
        }
    }
}
