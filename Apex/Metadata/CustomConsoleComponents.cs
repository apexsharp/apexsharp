namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_CustomConsoleComponents.htm#apex_class_Metadata_CustomConsoleComponents
    /// </summary>
    public class CustomConsoleComponents
    {
        // infrastructure
        public CustomConsoleComponents(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CustomConsoleComponents));
            }
        }

        // API
        PrimaryTabComponents primaryTabComponents
        {
            get
            {
                return Self.primaryTabComponents;
            }
            set
            {
                Self.primaryTabComponents = value;
            }
        }

        SubtabComponents subtabComponents
        {
            get
            {
                return Self.subtabComponents;
            }
            set
            {
                Self.subtabComponents = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public CustomConsoleComponents()
        {
            Self = Implementation.Constructor();
        }
    }
}
