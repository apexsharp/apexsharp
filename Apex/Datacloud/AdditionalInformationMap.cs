namespace Apex.Datacloud
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Datacloud_AdditionalInformationMap.htm#apex_class_Datacloud_AdditionalInformationMap
    /// </summary>
    public class AdditionalInformationMap
    {
        // infrastructure
        public AdditionalInformationMap(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AdditionalInformationMap));
            }
        }

        // API
        public string getName()
        {
            return Self.getName();
        }

        public string getValue()
        {
            return Self.getValue();
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

        string value
        {
            get
            {
                return Self.value;
            }
            set
            {
                Self.value = value;
            }
        }
    }
}
