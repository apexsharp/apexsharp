namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CommentCapabilities
    {
        // infrastructure
        public CommentCapabilities(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CommentCapabilities));
            }
        }

        // API
        object content
        {
            get
            {
                return Self.content;
            }
            set
            {
                Self.content = value;
            }
        }

        object edit
        {
            get
            {
                return Self.edit;
            }
            set
            {
                Self.edit = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
            }
        }

        object upDownVote
        {
            get
            {
                return Self.upDownVote;
            }
            set
            {
                Self.upDownVote = value;
            }
        }

        object verified
        {
            get
            {
                return Self.verified;
            }
            set
            {
                Self.verified = value;
            }
        }

        public CommentCapabilities()
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
