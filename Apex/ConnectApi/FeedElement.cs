namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedElement
    {
        // infrastructure
        public FeedElement(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedElement));
            }
        }

        // API
        object body
        {
            get
            {
                return Self.body;
            }
            set
            {
                Self.body = value;
            }
        }

        object capabilities
        {
            get
            {
                return Self.capabilities;
            }
            set
            {
                Self.capabilities = value;
            }
        }

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

        object feedElementType
        {
            get
            {
                return Self.feedElementType;
            }
            set
            {
                Self.feedElementType = value;
            }
        }

        object header
        {
            get
            {
                return Self.header;
            }
            set
            {
                Self.header = value;
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

        object modifiedDate
        {
            get
            {
                return Self.modifiedDate;
            }
            set
            {
                Self.modifiedDate = value;
            }
        }

        object parent
        {
            get
            {
                return Self.parent;
            }
            set
            {
                Self.parent = value;
            }
        }

        object relativeCreatedDate
        {
            get
            {
                return Self.relativeCreatedDate;
            }
            set
            {
                Self.relativeCreatedDate = value;
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
