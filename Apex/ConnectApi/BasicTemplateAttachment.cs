namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BasicTemplateAttachment
    {
        // infrastructure
        public BasicTemplateAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BasicTemplateAttachment));
            }
        }

        // API
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

        object icon
        {
            get
            {
                return Self.icon;
            }
            set
            {
                Self.icon = value;
            }
        }

        object linkRecordId
        {
            get
            {
                return Self.linkRecordId;
            }
            set
            {
                Self.linkRecordId = value;
            }
        }

        object linkUrl
        {
            get
            {
                return Self.linkUrl;
            }
            set
            {
                Self.linkUrl = value;
            }
        }

        object subtype
        {
            get
            {
                return Self.subtype;
            }
            set
            {
                Self.subtype = value;
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

        public BasicTemplateAttachment()
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
