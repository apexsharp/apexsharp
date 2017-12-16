namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_DataSourceUtil.htm#apex_class_DataSource_DataSourceUtil
    /// </summary>
    public class DataSourceUtil
    {
        // infrastructure
        public DataSourceUtil(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DataSourceUtil));
            }
        }

        // API
        public void logWarning(string message)
        {
            Self.logWarning(message);
        }

        public void throwException(string message)
        {
            Self.throwException(message);
        }
    }
}
