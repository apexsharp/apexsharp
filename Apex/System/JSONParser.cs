namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_JsonParser.htm#apex_class_System_JsonParser
    /// </summary>
    public class JSONParser
    {
        // infrastructure
        public JSONParser(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JSONParser));
            }
        }

        // API
        public void clearCurrentToken()
        {
            Self.clearCurrentToken();
        }

        public Blob getBlobValue()
        {
            return Self.getBlobValue();
        }

        public bool getBooleanValue()
        {
            return Self.getBooleanValue();
        }

        public string getCurrentName()
        {
            return Self.getCurrentName();
        }

        public JSONToken getCurrentToken()
        {
            return Self.getCurrentToken();
        }

        public Datetime getDatetimeValue()
        {
            return Self.getDatetimeValue();
        }

        public Date getDateValue()
        {
            return Self.getDateValue();
        }

        public decimal getDecimalValue()
        {
            return Self.getDecimalValue();
        }

        public double getDoubleValue()
        {
            return Self.getDoubleValue();
        }

        public ID getIdValue()
        {
            return Self.getIdValue();
        }

        public int getIntegerValue()
        {
            return Self.getIntegerValue();
        }

        public JSONToken getLastClearedToken()
        {
            return Self.getLastClearedToken();
        }

        public long getLongValue()
        {
            return Self.getLongValue();
        }

        public string getText()
        {
            return Self.getText();
        }

        public Time getTimeValue()
        {
            return Self.getTimeValue();
        }

        public bool hasCurrentToken()
        {
            return Self.hasCurrentToken();
        }

        public JSONToken nextToken()
        {
            return Self.nextToken();
        }

        public JSONToken nextValue()
        {
            return Self.nextValue();
        }

        public object readValueAs(Type apexType)
        {
            return Self.readValueAs(apexType);
        }

        public object readValueAsStrict(Type apexType)
        {
            return Self.readValueAsStrict(apexType);
        }

        public void skipChildren()
        {
            Self.skipChildren();
        }

        public object clone()
        {
            return Self.clone();
        }

        public Datetime getDateTimeValue()
        {
            return Self.getDateTimeValue();
        }
    }
}
