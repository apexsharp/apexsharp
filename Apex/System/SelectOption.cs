namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_selectoption.htm#apex_pages_selectoption
    /// </summary>
    public class SelectOption
    {
        // infrastructure
        public SelectOption(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SelectOption));
            }
        }

        // API
        public SelectOption(string value, string label)
        {
            Implementation.Constructor(value, label);
        }

        public SelectOption(string value, string label, bool isDisabled)
        {
            Implementation.Constructor(value, label, isDisabled);
        }

        public bool getDisabled()
        {
            return Self.getDisabled();
        }

        public bool getEscapeItem()
        {
            return Self.getEscapeItem();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public string getValue()
        {
            return Self.getValue();
        }

        public void setDisabled(bool isDisabled)
        {
            Self.setDisabled(isDisabled);
        }

        public void setEscapeItem(bool itemsEscaped)
        {
            Self.setEscapeItem(itemsEscaped);
        }

        public void setLabel(string label)
        {
            Self.setLabel(label);
        }

        public void setValue(string value)
        {
            Self.setValue(value);
        }
    }
}
