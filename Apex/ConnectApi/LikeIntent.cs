namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class LikeIntent
    {
        // infrastructure
        public LikeIntent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(LikeIntent));
            }
        }

        // API
        object isLiked
        {
            get
            {
                return Self.isLiked;
            }
            set
            {
                Self.isLiked = value;
            }
        }

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

        public LikeIntent()
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
