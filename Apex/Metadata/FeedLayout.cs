namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_FeedLayout.htm#apex_class_Metadata_FeedLayout
    /// </summary>
    public class FeedLayout
    {
        // infrastructure
        public FeedLayout(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedLayout));
            }
        }

        // API
        bool autocollapsePublisher
        {
            get
            {
                return Self.autocollapsePublisher;
            }
            set
            {
                Self.autocollapsePublisher = value;
            }
        }

        bool compactFeed
        {
            get
            {
                return Self.compactFeed;
            }
            set
            {
                Self.compactFeed = value;
            }
        }

        FeedLayoutFilterPosition feedFilterPosition
        {
            get
            {
                return Self.feedFilterPosition;
            }
            set
            {
                Self.feedFilterPosition = value;
            }
        }

        List<FeedLayoutFilter> feedFilters
        {
            get
            {
                return Self.feedFilters;
            }
            set
            {
                Self.feedFilters = value;
            }
        }

        bool fullWidthFeed
        {
            get
            {
                return Self.fullWidthFeed;
            }
            set
            {
                Self.fullWidthFeed = value;
            }
        }

        bool hideSidebar
        {
            get
            {
                return Self.hideSidebar;
            }
            set
            {
                Self.hideSidebar = value;
            }
        }

        bool highlightExternalFeedItems
        {
            get
            {
                return Self.highlightExternalFeedItems;
            }
            set
            {
                Self.highlightExternalFeedItems = value;
            }
        }

        List<FeedLayoutComponent> leftComponents
        {
            get
            {
                return Self.leftComponents;
            }
            set
            {
                Self.leftComponents = value;
            }
        }

        List<FeedLayoutComponent> rightComponents
        {
            get
            {
                return Self.rightComponents;
            }
            set
            {
                Self.rightComponents = value;
            }
        }

        bool useInlineFiltersInConsole
        {
            get
            {
                return Self.useInlineFiltersInConsole;
            }
            set
            {
                Self.useInlineFiltersInConsole = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public FeedLayout()
        {
            Implementation.Constructor();
        }
    }
}
