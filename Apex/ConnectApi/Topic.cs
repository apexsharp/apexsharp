namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Topic
    {
        // infrastructure
        public Topic(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Topic));
            }
        }

        // API
        object createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
            }
        }

        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
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

        object images
        {
            get
            {
                return Self.images;
            }
            set
            {
                Self.images = value;
            }
        }

        object isBeingDeleted
        {
            get
            {
                return Self.isBeingDeleted;
            }
            set
            {
                Self.isBeingDeleted = value;
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

        object nonLocalizedName
        {
            get
            {
                return Self.nonLocalizedName;
            }
            set
            {
                Self.nonLocalizedName = value;
            }
        }

        object talkingAbout
        {
            get
            {
                return Self.talkingAbout;
            }
            set
            {
                Self.talkingAbout = value;
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

        public Topic()
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
