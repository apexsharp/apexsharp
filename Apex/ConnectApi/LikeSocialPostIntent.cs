namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LikeSocialPostIntent
    {
        // infrastructure
        public LikeSocialPostIntent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LikeSocialPostIntent));
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

        object socialPostId
        {
            get
            {
                return Self.socialPostId;
            }
            set
            {
                Self.socialPostId = value;
            }
        }

        public LikeSocialPostIntent()
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
