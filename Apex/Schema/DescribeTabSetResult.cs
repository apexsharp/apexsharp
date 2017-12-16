namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_schema_describetabsetresult.htm#apex_class_schema_describetabsetresult
    /// </summary>
    public class DescribeTabSetResult
    {
        // infrastructure
        public DescribeTabSetResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeTabSetResult));
            }
        }

        // API
        public string getDescription()
        {
            return Self.getDescription();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getLogoUrl()
        {
            return Self.getLogoUrl();
        }

        public string getNamespace()
        {
            return Self.getNamespace();
        }

        public List<DescribeTabResult> getTabs()
        {
            return Self.getTabs();
        }

        public bool isSelected()
        {
            return Self.isSelected();
        }

        string description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
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

        string logoUrl
        {
            get
            {
                return Self.logoUrl;
            }
            set
            {
                Self.logoUrl = value;
            }
        }

        string @namespace
        {
            get
            {
                return Self.@namespace;
            }
            set
            {
                Self.@namespace = value;
            }
        }

        bool selected
        {
            get
            {
                return Self.selected;
            }
            set
            {
                Self.selected = value;
            }
        }

        List<DescribeTabResult> tabs
        {
            get
            {
                return Self.tabs;
            }
            set
            {
                Self.tabs = value;
            }
        }

        string tabSetId
        {
            get
            {
                return Self.tabSetId;
            }
            set
            {
                Self.tabSetId = value;
            }
        }

        public string getTabSetId()
        {
            return Self.getTabSetId();
        }
    }
}
