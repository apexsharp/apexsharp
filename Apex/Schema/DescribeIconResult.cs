namespace Apex.Schema
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_schema_describeiconresult.htm#apex_class_schema_describeiconresult
    /// </summary>
    public class DescribeIconResult
    {
        // infrastructure
        public DescribeIconResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DescribeIconResult));
            }
        }

        // API
        public string getContentType()
        {
            return Self.getContentType();
        }

        public int getHeight()
        {
            return Self.getHeight();
        }

        public string getTheme()
        {
            return Self.getTheme();
        }

        public string getUrl()
        {
            return Self.getUrl();
        }

        public int getWidth()
        {
            return Self.getWidth();
        }

        string contentType
        {
            get
            {
                return Self.contentType;
            }
            set
            {
                Self.contentType = value;
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

        string theme
        {
            get
            {
                return Self.theme;
            }
            set
            {
                Self.theme = value;
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
    }
}
