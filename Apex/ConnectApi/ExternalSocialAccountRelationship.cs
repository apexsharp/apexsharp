namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ExternalSocialAccountRelationship
    {
        // infrastructure
        public ExternalSocialAccountRelationship(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ExternalSocialAccountRelationship));
            }
        }

        // API
        object externalSocialAccountId
        {
            get
            {
                return Self.externalSocialAccountId;
            }
            set
            {
                Self.externalSocialAccountId = value;
            }
        }

        object isFollowed
        {
            get
            {
                return Self.isFollowed;
            }
            set
            {
                Self.isFollowed = value;
            }
        }

        object isFollowing
        {
            get
            {
                return Self.isFollowing;
            }
            set
            {
                Self.isFollowing = value;
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

        public ExternalSocialAccountRelationship()
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
