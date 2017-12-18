namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CanvasTemplateAttachment
    {
        // infrastructure
        public CanvasTemplateAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CanvasTemplateAttachment));
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

        object developerName
        {
            get
            {
                return Self.developerName;
            }
            set
            {
                Self.developerName = value;
            }
        }

        object height
        {
            get
            {
                return Self.height;
            }
            set
            {
                Self.height = value;
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

        object namespacePrefix
        {
            get
            {
                return Self.namespacePrefix;
            }
            set
            {
                Self.namespacePrefix = value;
            }
        }

        object parameters
        {
            get
            {
                return Self.parameters;
            }
            set
            {
                Self.parameters = value;
            }
        }

        object thumbnailUrl
        {
            get
            {
                return Self.thumbnailUrl;
            }
            set
            {
                Self.thumbnailUrl = value;
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

        public CanvasTemplateAttachment()
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
