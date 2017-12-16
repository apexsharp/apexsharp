namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RecommendationChannel
    {
        // infrastructure
        public RecommendationChannel(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RecommendationChannel));
            }
        }

        // API
        object CustomChannel1
        {
            get
            {
                return Self.CustomChannel1;
            }
            set
            {
                Self.CustomChannel1 = value;
            }
        }

        object CustomChannel2
        {
            get
            {
                return Self.CustomChannel2;
            }
            set
            {
                Self.CustomChannel2 = value;
            }
        }

        object CustomChannel3
        {
            get
            {
                return Self.CustomChannel3;
            }
            set
            {
                Self.CustomChannel3 = value;
            }
        }

        object CustomChannel4
        {
            get
            {
                return Self.CustomChannel4;
            }
            set
            {
                Self.CustomChannel4 = value;
            }
        }

        object CustomChannel5
        {
            get
            {
                return Self.CustomChannel5;
            }
            set
            {
                Self.CustomChannel5 = value;
            }
        }

        object DefaultChannel
        {
            get
            {
                return Self.DefaultChannel;
            }
            set
            {
                Self.DefaultChannel = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<RecommendationChannel> values()
        {
            return Implementation.values();
        }
    }
}
