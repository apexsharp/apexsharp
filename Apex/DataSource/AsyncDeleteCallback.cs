namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_AsyncDeleteCallback.htm#apex_class_DataSource_AsyncDeleteCallback
    /// </summary>
    public class AsyncDeleteCallback
    {
        // infrastructure
        public AsyncDeleteCallback(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AsyncDeleteCallback));
            }
        }

        // API
        public void processDelete(DeleteResult deleteResult)
        {
            Self.processDelete(deleteResult);
        }
    }
}
