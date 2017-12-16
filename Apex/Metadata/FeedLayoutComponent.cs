namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_FeedLayoutComponent.htm#apex_class_Metadata_FeedLayoutComponent
    /// </summary>
    public class FeedLayoutComponent
    {
        // infrastructure
        public FeedLayoutComponent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedLayoutComponent));
            }
        }

        // API
        FeedLayoutComponentType componentType
        {
            get
            {
                return Self.componentType;
            }
            set
            {
                Self.componentType = value;
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

        string page_x
        {
            get
            {
                return Self.page_x;
            }
            set
            {
                Self.page_x = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public FeedLayoutComponent()
        {
            Implementation.Constructor();
        }
    }
}
