namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class KnowledgeArticleVersion
    {
        // infrastructure
        public KnowledgeArticleVersion(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(KnowledgeArticleVersion));
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

        object knowledgeArticleId
        {
            get
            {
                return Self.knowledgeArticleId;
            }
            set
            {
                Self.knowledgeArticleId = value;
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

        public KnowledgeArticleVersion()
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
