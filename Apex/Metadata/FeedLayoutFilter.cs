namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_FeedLayoutFilter.htm#apex_class_Metadata_FeedLayoutFilter
    /// </summary>
    public class FeedLayoutFilter
    {
        // infrastructure
        public FeedLayoutFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedLayoutFilter));
            }
        }

        // API
        string feedFilterName
        {
            get
            {
                return Self.feedFilterName;
            }
            set
            {
                Self.feedFilterName = value;
            }
        }

        FeedLayoutFilterType feedFilterType
        {
            get
            {
                return Self.feedFilterType;
            }
            set
            {
                Self.feedFilterType = value;
            }
        }

        FeedItemTypeEnum feedItemType
        {
            get
            {
                return Self.feedItemType;
            }
            set
            {
                Self.feedItemType = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public FeedLayoutFilter()
        {
            Self = Implementation.Constructor();
        }
    }
}
