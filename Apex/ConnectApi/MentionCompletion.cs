namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class MentionCompletion
    {
        // infrastructure
        public MentionCompletion(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(MentionCompletion));
            }
        }

        // API
        object additionalLabel
        {
            get
            {
                return Self.additionalLabel;
            }
            set
            {
                Self.additionalLabel = value;
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

        object outOfOffice
        {
            get
            {
                return Self.outOfOffice;
            }
            set
            {
                Self.outOfOffice = value;
            }
        }

        object photoUrl
        {
            get
            {
                return Self.photoUrl;
            }
            set
            {
                Self.photoUrl = value;
            }
        }

        object recordId
        {
            get
            {
                return Self.recordId;
            }
            set
            {
                Self.recordId = value;
            }
        }

        object userType
        {
            get
            {
                return Self.userType;
            }
            set
            {
                Self.userType = value;
            }
        }

        public MentionCompletion()
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
