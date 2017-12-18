namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_Container.htm#apex_class_Metadata_Container
    /// </summary>
    public class Container
    {
        // infrastructure
        public Container(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Container));
            }
        }

        // API
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

        bool isContainerAutoSizeEnabled
        {
            get
            {
                return Self.isContainerAutoSizeEnabled;
            }
            set
            {
                Self.isContainerAutoSizeEnabled = value;
            }
        }

        string region
        {
            get
            {
                return Self.region;
            }
            set
            {
                Self.region = value;
            }
        }

        List<SidebarComponent> sidebarComponents
        {
            get
            {
                return Self.sidebarComponents;
            }
            set
            {
                Self.sidebarComponents = value;
            }
        }

        string style
        {
            get
            {
                return Self.style;
            }
            set
            {
                Self.style = value;
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

        public Container()
        {
            Self = Implementation.Constructor();
        }
    }
}
