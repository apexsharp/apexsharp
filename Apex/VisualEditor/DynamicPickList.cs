namespace Apex.VisualEditor
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_VisualEditor_DynamicPickList.htm#apex_class_VisualEditor_DynamicPickList
    /// </summary>
    public class DynamicPickList
    {
        // infrastructure
        public DynamicPickList(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DynamicPickList));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public DataRow getDefaultValue()
        {
            return Self.getDefaultValue();
        }

        public string getLabel(object attributeValue)
        {
            return Self.getLabel(attributeValue);
        }

        public DynamicPickListRows getValues()
        {
            return Self.getValues();
        }

        public bool isValid(object attributeValue)
        {
            return Self.isValid(attributeValue);
        }

        public DynamicPickList()
        {
            Self = Implementation.Constructor();
        }
    }
}
