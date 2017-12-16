namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialPostIntents
    {
        // infrastructure
        public SocialPostIntents(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialPostIntents));
            }
        }

        // API
        object approvalIntent
        {
            get
            {
                return Self.approvalIntent;
            }
            set
            {
                Self.approvalIntent = value;
            }
        }

        object deleteIntent
        {
            get
            {
                return Self.deleteIntent;
            }
            set
            {
                Self.deleteIntent = value;
            }
        }

        object followIntent
        {
            get
            {
                return Self.followIntent;
            }
            set
            {
                Self.followIntent = value;
            }
        }

        object hideIntent
        {
            get
            {
                return Self.hideIntent;
            }
            set
            {
                Self.hideIntent = value;
            }
        }

        object likeIntent
        {
            get
            {
                return Self.likeIntent;
            }
            set
            {
                Self.likeIntent = value;
            }
        }

        object replyIntent
        {
            get
            {
                return Self.replyIntent;
            }
            set
            {
                Self.replyIntent = value;
            }
        }

        public SocialPostIntents()
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
