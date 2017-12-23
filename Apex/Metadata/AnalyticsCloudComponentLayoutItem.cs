namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_AnalyticsCloudComponentLayoutItem.htm#apex_class_Metadata_AnalyticsCloudComponentLayoutItem
    /// </summary>
    public class AnalyticsCloudComponentLayoutItem
    {
        // infrastructure
        public AnalyticsCloudComponentLayoutItem(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AnalyticsCloudComponentLayoutItem));
            }
        }

        // API
        string assetType
        {
            get
            {
                return Self.assetType;
            }
            set
            {
                Self.assetType = value;
            }
        }

        string devName
        {
            get
            {
                return Self.devName;
            }
            set
            {
                Self.devName = value;
            }
        }

        string error
        {
            get
            {
                return Self.error;
            }
            set
            {
                Self.error = value;
            }
        }

        string filter
        {
            get
            {
                return Self.filter;
            }
            set
            {
                Self.filter = value;
            }
        }

        int height
        {
            get
            {
                return Self.height;
            }
            set
            {
                Self.height = value;
            }
        }

        bool hideOnError
        {
            get
            {
                return Self.hideOnError;
            }
            set
            {
                Self.hideOnError = value;
            }
        }

        bool showSharing
        {
            get
            {
                return Self.showSharing;
            }
            set
            {
                Self.showSharing = value;
            }
        }

        bool showTitle
        {
            get
            {
                return Self.showTitle;
            }
            set
            {
                Self.showTitle = value;
            }
        }

        string width
        {
            get
            {
                return Self.width;
            }
            set
            {
                Self.width = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        object showHeader
        {
            get
            {
                return Self.showHeader;
            }
            set
            {
                Self.showHeader = value;
            }
        }

        public AnalyticsCloudComponentLayoutItem()
        {
            Self = Implementation.Constructor();
        }
    }
}
