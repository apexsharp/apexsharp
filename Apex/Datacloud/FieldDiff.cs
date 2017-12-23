namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_FieldDiff.htm#apex_class_Datacloud_FieldDiff
    /// </summary>
    public class FieldDiff
    {
        // infrastructure
        public FieldDiff(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FieldDiff));
            }
        }

        // API
        public string getDifference()
        {
            return Self.getDifference();
        }

        public string getName()
        {
            return Self.getName();
        }

        string difference
        {
            get
            {
                return Self.difference;
            }
            set
            {
                Self.difference = value;
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
    }
}
