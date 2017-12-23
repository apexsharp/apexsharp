namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecommendationDefinition
    {
        // infrastructure
        public RecommendationDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecommendationDefinition));
            }
        }

        // API
        object actionUrl
        {
            get
            {
                return Self.actionUrl;
            }
            set
            {
                Self.actionUrl = value;
            }
        }

        object actionUrlName
        {
            get
            {
                return Self.actionUrlName;
            }
            set
            {
                Self.actionUrlName = value;
            }
        }

        object explanation
        {
            get
            {
                return Self.explanation;
            }
            set
            {
                Self.explanation = value;
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

        object photo
        {
            get
            {
                return Self.photo;
            }
            set
            {
                Self.photo = value;
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

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public RecommendationDefinition()
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
