namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubFieldDefinition
    {
        // infrastructure
        public ContentHubFieldDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubFieldDefinition));
            }
        }

        // API
        object displayName
        {
            get
            {
                return Self.displayName;
            }
            set
            {
                Self.displayName = value;
            }
        }

        object isMandatory
        {
            get
            {
                return Self.isMandatory;
            }
            set
            {
                Self.isMandatory = value;
            }
        }

        object maxLength
        {
            get
            {
                return Self.maxLength;
            }
            set
            {
                Self.maxLength = value;
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

        object type
        {
            get
            {
                return Self.type;
            }
            set
            {
                Self.type = value;
            }
        }

        public ContentHubFieldDefinition()
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
