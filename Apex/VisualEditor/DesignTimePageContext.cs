namespace Apex.VisualEditor
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_VisualEditor_DesignTimePageContext.htm#apex_class_VisualEditor_DesignTimePageContext
    /// </summary>
    public class DesignTimePageContext
    {
        // infrastructure
        public DesignTimePageContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DesignTimePageContext));
            }
        }

        // API
        string entityName
        {
            get
            {
                return Self.entityName;
            }
            set
            {
                Self.entityName = value;
            }
        }

        string pageType
        {
            get
            {
                return Self.pageType;
            }
            set
            {
                Self.pageType = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public DesignTimePageContext()
        {
            Self = Implementation.Constructor();
        }
    }
}
