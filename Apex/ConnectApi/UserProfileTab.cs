namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UserProfileTab
    {
        // infrastructure
        public UserProfileTab(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserProfileTab));
            }
        }

        // API
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

        object isDefault
        {
            get
            {
                return Self.isDefault;
            }
            set
            {
                Self.isDefault = value;
            }
        }

        object tabType
        {
            get
            {
                return Self.tabType;
            }
            set
            {
                Self.tabType = value;
            }
        }

        object tabUrl
        {
            get
            {
                return Self.tabUrl;
            }
            set
            {
                Self.tabUrl = value;
            }
        }

        public UserProfileTab()
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
