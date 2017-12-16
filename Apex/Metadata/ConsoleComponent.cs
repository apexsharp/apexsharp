namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_ConsoleComponent.htm#apex_class_Metadata_ConsoleComponent
    /// </summary>
    public class ConsoleComponent
    {
        // infrastructure
        public ConsoleComponent(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ConsoleComponent));
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

        string location
        {
            get
            {
                return Self.location;
            }
            set
            {
                Self.location = value;
            }
        }

        string visualforcePage
        {
            get
            {
                return Self.visualforcePage;
            }
            set
            {
                Self.visualforcePage = value;
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

        public ConsoleComponent()
        {
            Implementation.Constructor();
        }
    }
}
