namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ActorWithId
    {
        // infrastructure
        public ActorWithId(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ActorWithId));
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

        object motif
        {
            get
            {
                return Self.motif;
            }
            set
            {
                Self.motif = value;
            }
        }

        object mySubscription
        {
            get
            {
                return Self.mySubscription;
            }
            set
            {
                Self.mySubscription = value;
            }
        }

        object recordViewUrl
        {
            get
            {
                return Self.recordViewUrl;
            }
            set
            {
                Self.recordViewUrl = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
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
