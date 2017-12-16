namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_SidebarComponent.htm#apex_class_Metadata_SidebarComponent
    /// </summary>
    public class SidebarComponent
    {
        // infrastructure
        public SidebarComponent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SidebarComponent));
            }
        }

        // API
        string componentType
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

        bool knowledgeOneEnable
        {
            get
            {
                return Self.knowledgeOneEnable;
            }
            set
            {
                Self.knowledgeOneEnable = value;
            }
        }

        string label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        string lookup
        {
            get
            {
                return Self.lookup;
            }
            set
            {
                Self.lookup = value;
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

        List<RelatedList> relatedLists
        {
            get
            {
                return Self.relatedLists;
            }
            set
            {
                Self.relatedLists = value;
            }
        }

        string unit
        {
            get
            {
                return Self.unit;
            }
            set
            {
                Self.unit = value;
            }
        }

        int width
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

        public SidebarComponent()
        {
            Implementation.Constructor();
        }
    }
}
