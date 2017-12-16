namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ChatterLikesCapability
    {
        // infrastructure
        public ChatterLikesCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterLikesCapability));
            }
        }

        // API
        object isLikedByCurrentUser
        {
            get
            {
                return Self.isLikedByCurrentUser;
            }
            set
            {
                Self.isLikedByCurrentUser = value;
            }
        }

        object likesMessage
        {
            get
            {
                return Self.likesMessage;
            }
            set
            {
                Self.likesMessage = value;
            }
        }

        object myLike
        {
            get
            {
                return Self.myLike;
            }
            set
            {
                Self.myLike = value;
            }
        }

        object page
        {
            get
            {
                return Self.page;
            }
            set
            {
                Self.page = value;
            }
        }

        public ChatterLikesCapability()
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
