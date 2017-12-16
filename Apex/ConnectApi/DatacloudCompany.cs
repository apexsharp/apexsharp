namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class DatacloudCompany
    {
        // infrastructure
        public DatacloudCompany(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DatacloudCompany));
            }
        }

        // API
        object activeContacts
        {
            get
            {
                return Self.activeContacts;
            }
            set
            {
                Self.activeContacts = value;
            }
        }

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

        object annualRevenue
        {
            get
            {
                return Self.annualRevenue;
            }
            set
            {
                Self.annualRevenue = value;
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

        object dunsNumber
        {
            get
            {
                return Self.dunsNumber;
            }
            set
            {
                Self.dunsNumber = value;
            }
        }

        object industry
        {
            get
            {
                return Self.industry;
            }
            set
            {
                Self.industry = value;
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

        object naicsCode
        {
            get
            {
                return Self.naicsCode;
            }
            set
            {
                Self.naicsCode = value;
            }
        }

        object naicsDescription
        {
            get
            {
                return Self.naicsDescription;
            }
            set
            {
                Self.naicsDescription = value;
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

        object numberOfEmployees
        {
            get
            {
                return Self.numberOfEmployees;
            }
            set
            {
                Self.numberOfEmployees = value;
            }
        }

        object ownership
        {
            get
            {
                return Self.ownership;
            }
            set
            {
                Self.ownership = value;
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

        object sic
        {
            get
            {
                return Self.sic;
            }
            set
            {
                Self.sic = value;
            }
        }

        object sicDescription
        {
            get
            {
                return Self.sicDescription;
            }
            set
            {
                Self.sicDescription = value;
            }
        }

        object site
        {
            get
            {
                return Self.site;
            }
            set
            {
                Self.site = value;
            }
        }

        object tickerSymbol
        {
            get
            {
                return Self.tickerSymbol;
            }
            set
            {
                Self.tickerSymbol = value;
            }
        }

        object tradeStyle
        {
            get
            {
                return Self.tradeStyle;
            }
            set
            {
                Self.tradeStyle = value;
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

        object website
        {
            get
            {
                return Self.website;
            }
            set
            {
                Self.website = value;
            }
        }

        object yearStarted
        {
            get
            {
                return Self.yearStarted;
            }
            set
            {
                Self.yearStarted = value;
            }
        }

        public DatacloudCompany()
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
