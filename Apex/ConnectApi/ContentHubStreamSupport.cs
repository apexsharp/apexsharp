namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubStreamSupport
    {
        // infrastructure
        public ContentHubStreamSupport(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubStreamSupport));
            }
        }

        // API
        object ContentStreamAllowed
        {
            get
            {
                return Self.ContentStreamAllowed;
            }
            set
            {
                Self.ContentStreamAllowed = value;
            }
        }

        object ContentStreamNotAllowed
        {
            get
            {
                return Self.ContentStreamNotAllowed;
            }
            set
            {
                Self.ContentStreamNotAllowed = value;
            }
        }

        object ContentStreamRequired
        {
            get
            {
                return Self.ContentStreamRequired;
            }
            set
            {
                Self.ContentStreamRequired = value;
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

        public static List<ContentHubStreamSupport> values()
        {
            return Implementation.values();
        }
    }
}
