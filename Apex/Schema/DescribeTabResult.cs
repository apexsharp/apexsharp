namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_schema_describetabresult.htm#apex_class_schema_describetabresult
    /// </summary>
    public class DescribeTabResult
    {
        // infrastructure
        public DescribeTabResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeTabResult));
            }
        }

        // API
        public List<DescribeColorResult> getColors()
        {
            return Self.getColors();
        }

        public string getIconUrl()
        {
            return Self.getIconUrl();
        }

        public List<DescribeIconResult> getIcons()
        {
            return Self.getIcons();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getMiniIconUrl()
        {
            return Self.getMiniIconUrl();
        }

        public string getSobjectName()
        {
            return Self.getSobjectName();
        }

        public string getUrl()
        {
            return Self.getUrl();
        }

        public bool isCustom()
        {
            return Self.isCustom();
        }

        List<DescribeColorResult> colors
        {
            get
            {
                return Self.colors;
            }
            set
            {
                Self.colors = value;
            }
        }

        bool custom
        {
            get
            {
                return Self.custom;
            }
            set
            {
                Self.custom = value;
            }
        }

        List<DescribeIconResult> icons
        {
            get
            {
                return Self.icons;
            }
            set
            {
                Self.icons = value;
            }
        }

        string iconUrl
        {
            get
            {
                return Self.iconUrl;
            }
            set
            {
                Self.iconUrl = value;
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

        string miniIconUrl
        {
            get
            {
                return Self.miniIconUrl;
            }
            set
            {
                Self.miniIconUrl = value;
            }
        }

        string name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        string sobjectName
        {
            get
            {
                return Self.sobjectName;
            }
            set
            {
                Self.sobjectName = value;
            }
        }

        string tabEnumOrId
        {
            get
            {
                return Self.tabEnumOrId;
            }
            set
            {
                Self.tabEnumOrId = value;
            }
        }

        string url
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

        public string getName()
        {
            return Self.getName();
        }

        public string getTabEnumOrId()
        {
            return Self.getTabEnumOrId();
        }
    }
}
