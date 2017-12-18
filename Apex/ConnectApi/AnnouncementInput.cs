namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class AnnouncementInput
    {
        // infrastructure
        public AnnouncementInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AnnouncementInput));
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

        object feedItemId
        {
            get
            {
                return Self.feedItemId;
            }
            set
            {
                Self.feedItemId = value;
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

        object parentId
        {
            get
            {
                return Self.parentId;
            }
            set
            {
                Self.parentId = value;
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

        public AnnouncementInput()
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
