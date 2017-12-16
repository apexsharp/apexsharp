namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class VisualforcePage
    {
        // infrastructure
        public VisualforcePage(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(VisualforcePage));
            }
        }

        // API
        bool showLabel
        {
            get
            {
                return Self.showLabel;
            }
            set
            {
                Self.showLabel = value;
            }
        }

        bool showScrollbars
        {
            get
            {
                return Self.showScrollbars;
            }
            set
            {
                Self.showScrollbars = value;
            }
        }

        string suggestedHeight
        {
            get
            {
                return Self.suggestedHeight;
            }
            set
            {
                Self.suggestedHeight = value;
            }
        }

        string suggestedWidth
        {
            get
            {
                return Self.suggestedWidth;
            }
            set
            {
                Self.suggestedWidth = value;
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

        public int getDisplayLines()
        {
            return Self.getDisplayLines();
        }

        public bool getShowLabel()
        {
            return Self.getShowLabel();
        }

        public bool getShowScrollbars()
        {
            return Self.getShowScrollbars();
        }

        public string getSuggestedHeight()
        {
            return Self.getSuggestedHeight();
        }

        public string getSuggestedWidth()
        {
            return Self.getSuggestedWidth();
        }

        public int getTabOrder()
        {
            return Self.getTabOrder();
        }

        public string getType()
        {
            return Self.getType();
        }

        public string getUrl()
        {
            return Self.getUrl();
        }

        public string getValue()
        {
            return Self.getValue();
        }
    }
}
