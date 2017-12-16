namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Announcement
    {
        // infrastructure
        public Announcement(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Announcement));
            }
        }

        // API
        object expirationDate
        {
            get
            {
                return Self.expirationDate;
            }
            set
            {
                Self.expirationDate = value;
            }
        }

        object feedElement
        {
            get
            {
                return Self.feedElement;
            }
            set
            {
                Self.feedElement = value;
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

        object isArchived
        {
            get
            {
                return Self.isArchived;
            }
            set
            {
                Self.isArchived = value;
            }
        }

        object sendEmails
        {
            get
            {
                return Self.sendEmails;
            }
            set
            {
                Self.sendEmails = value;
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

        public Announcement()
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
