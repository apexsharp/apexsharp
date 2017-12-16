namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ArticleSummary
    {
        // infrastructure
        public ArticleSummary(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ArticleSummary));
            }
        }

        // API
        object articleType
        {
            get
            {
                return Self.articleType;
            }
            set
            {
                Self.articleType = value;
            }
        }

        object knowledgeArticleVersionId
        {
            get
            {
                return Self.knowledgeArticleVersionId;
            }
            set
            {
                Self.knowledgeArticleVersionId = value;
            }
        }

        object lastPublishedDate
        {
            get
            {
                return Self.lastPublishedDate;
            }
            set
            {
                Self.lastPublishedDate = value;
            }
        }

        object rating
        {
            get
            {
                return Self.rating;
            }
            set
            {
                Self.rating = value;
            }
        }

        object summary
        {
            get
            {
                return Self.summary;
            }
            set
            {
                Self.summary = value;
            }
        }

        object title
        {
            get
            {
                return Self.title;
            }
            set
            {
                Self.title = value;
            }
        }

        object urlName
        {
            get
            {
                return Self.urlName;
            }
            set
            {
                Self.urlName = value;
            }
        }

        object viewCount
        {
            get
            {
                return Self.viewCount;
            }
            set
            {
                Self.viewCount = value;
            }
        }

        public ArticleSummary()
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
