namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudContact
    {
        // infrastructure
        public DatacloudContact(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudContact));
            }
        }

        // API
        object address
        {
            get
            {
                return Self.address;
            }
            set
            {
                Self.address = value;
            }
        }

        object companyId
        {
            get
            {
                return Self.companyId;
            }
            set
            {
                Self.companyId = value;
            }
        }

        object companyName
        {
            get
            {
                return Self.companyName;
            }
            set
            {
                Self.companyName = value;
            }
        }

        object contactId
        {
            get
            {
                return Self.contactId;
            }
            set
            {
                Self.contactId = value;
            }
        }

        object department
        {
            get
            {
                return Self.department;
            }
            set
            {
                Self.department = value;
            }
        }

        object email
        {
            get
            {
                return Self.email;
            }
            set
            {
                Self.email = value;
            }
        }

        object firstName
        {
            get
            {
                return Self.firstName;
            }
            set
            {
                Self.firstName = value;
            }
        }

        object isInactive
        {
            get
            {
                return Self.isInactive;
            }
            set
            {
                Self.isInactive = value;
            }
        }

        object isOwned
        {
            get
            {
                return Self.isOwned;
            }
            set
            {
                Self.isOwned = value;
            }
        }

        object lastName
        {
            get
            {
                return Self.lastName;
            }
            set
            {
                Self.lastName = value;
            }
        }

        object level
        {
            get
            {
                return Self.level;
            }
            set
            {
                Self.level = value;
            }
        }

        object phoneNumbers
        {
            get
            {
                return Self.phoneNumbers;
            }
            set
            {
                Self.phoneNumbers = value;
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

        object updatedDate
        {
            get
            {
                return Self.updatedDate;
            }
            set
            {
                Self.updatedDate = value;
            }
        }

        public DatacloudContact()
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
