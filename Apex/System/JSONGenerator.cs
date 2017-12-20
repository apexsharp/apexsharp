namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_JsonGenerator.htm#apex_class_System_JsonGenerator
    /// </summary>
    public class JSONGenerator
    {
        // infrastructure
        public JSONGenerator(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JSONGenerator));
            }
        }

        // API
        public void close()
        {
            Self.close();
        }

        public string getAsString()
        {
            return Self.getAsString();
        }

        public bool isClosed()
        {
            return Self.isClosed();
        }

        public void writeBlob(Blob blobValue)
        {
            Self.writeBlob(blobValue);
        }

        public void writeBlobField(string fieldName, Blob blobValue)
        {
            Self.writeBlobField(fieldName, blobValue);
        }

        public void writeBoolean(bool blobValue)
        {
            Self.writeBoolean(blobValue);
        }

        public void writeBooleanField(string fieldName, bool booleanValue)
        {
            Self.writeBooleanField(fieldName, booleanValue);
        }

        public void writeDate(Date dateValue)
        {
            Self.writeDate(dateValue);
        }

        public void writeDateField(string fieldName, Date dateValue)
        {
            Self.writeDateField(fieldName, dateValue);
        }

        public void writeDateTime(Datetime datetimeValue)
        {
            Self.writeDateTime(datetimeValue);
        }

        public void writeDateTimeField(string fieldName, Datetime datetimeValue)
        {
            Self.writeDateTimeField(fieldName, datetimeValue);
        }

        public void writeEndArray()
        {
            Self.writeEndArray();
        }

        public void writeEndObject()
        {
            Self.writeEndObject();
        }

        public void writeFieldName(string fieldName)
        {
            Self.writeFieldName(fieldName);
        }

        public void writeId(ID identifier)
        {
            Self.writeId(identifier);
        }

        public void writeIdField(string fieldName, ID identifier)
        {
            Self.writeIdField(fieldName, identifier);
        }

        public void writeNull()
        {
            Self.writeNull();
        }

        public void writeNullField(string fieldName)
        {
            Self.writeNullField(fieldName);
        }

        public void writeNumber(decimal number)
        {
            Self.writeNumber(number);
        }

        public void writeNumber(double number)
        {
            Self.writeNumber(number);
        }

        public void writeNumber(int number)
        {
            Self.writeNumber(number);
        }

        public void writeNumber(long number)
        {
            Self.writeNumber(number);
        }

        public void writeNumberField(string fieldName, decimal number)
        {
            Self.writeNumberField(fieldName, number);
        }

        public void writeNumberField(string fieldName, double number)
        {
            Self.writeNumberField(fieldName, number);
        }

        public void writeNumberField(string fieldName, int number)
        {
            Self.writeNumberField(fieldName, number);
        }

        public void writeNumberField(string fieldName, long number)
        {
            Self.writeNumberField(fieldName, number);
        }

        public void writeObject(object anyObject)
        {
            Self.writeObject(anyObject);
        }

        public void writeObjectField(string fieldName, object value)
        {
            Self.writeObjectField(fieldName, value);
        }

        public void writeStartArray()
        {
            Self.writeStartArray();
        }

        public void writeStartObject()
        {
            Self.writeStartObject();
        }

        public void writeString(string stringValue)
        {
            Self.writeString(stringValue);
        }

        public void writeStringField(string fieldName, string stringValue)
        {
            Self.writeStringField(fieldName, stringValue);
        }

        public void writeTime(Time timeValue)
        {
            Self.writeTime(timeValue);
        }

        public void writeTimeField(string fieldName, Time timeValue)
        {
            Self.writeTimeField(fieldName, timeValue);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
