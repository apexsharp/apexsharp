namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Metadata_SubtabComponents.htm#apex_class_Metadata_SubtabComponents
    /// </summary>
    public class SubtabComponents
    {
        // infrastructure
        public SubtabComponents(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SubtabComponents));
            }
        }

        // API
        List<ConsoleComponent> component
        {
            get
            {
                return Self.component;
            }
            set
            {
                Self.component = value;
            }
        }

        List<Container> containers
        {
            get
            {
                return Self.containers;
            }
            set
            {
                Self.containers = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }

        public SubtabComponents()
        {
            Self = Implementation.Constructor();
        }
    }
}
