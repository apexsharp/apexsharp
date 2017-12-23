namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ContentHubExternalItemSharingType
    {
        // infrastructure
        public ContentHubExternalItemSharingType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentHubExternalItemSharingType));
            }
        }

        // API
        object DomainSharing
        {
            get
            {
                return Self.DomainSharing;
            }
            set
            {
                Self.DomainSharing = value;
            }
        }

        object PrivateSharing
        {
            get
            {
                return Self.PrivateSharing;
            }
            set
            {
                Self.PrivateSharing = value;
            }
        }

        object PublicSharing
        {
            get
            {
                return Self.PublicSharing;
            }
            set
            {
                Self.PublicSharing = value;
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

        public static List<ContentHubExternalItemSharingType> values()
        {
            return Implementation.values();
        }
    }
}
