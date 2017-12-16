namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FollowSocialPersonaIntent
    {
        // infrastructure
        public FollowSocialPersonaIntent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FollowSocialPersonaIntent));
            }
        }

        // API
        object managedSocialAccount
        {
            get
            {
                return Self.managedSocialAccount;
            }
            set
            {
                Self.managedSocialAccount = value;
            }
        }

        object socialPersonaId
        {
            get
            {
                return Self.socialPersonaId;
            }
            set
            {
                Self.socialPersonaId = value;
            }
        }

        public FollowSocialPersonaIntent()
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
