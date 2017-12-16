namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RelatedFeedPostType
    {
        // infrastructure
        public RelatedFeedPostType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedFeedPostType));
            }
        }

        // API
        object Answered
        {
            get
            {
                return Self.Answered;
            }
            set
            {
                Self.Answered = value;
            }
        }

        object BestAnswer
        {
            get
            {
                return Self.BestAnswer;
            }
            set
            {
                Self.BestAnswer = value;
            }
        }

        object Generic
        {
            get
            {
                return Self.Generic;
            }
            set
            {
                Self.Generic = value;
            }
        }

        object Unanswered
        {
            get
            {
                return Self.Unanswered;
            }
            set
            {
                Self.Unanswered = value;
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

        public static List<RelatedFeedPostType> values()
        {
            return Implementation.values();
        }
    }
}
