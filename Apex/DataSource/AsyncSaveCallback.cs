namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;
    using SaveResult = global::Apex.Database.SaveResult;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_AsyncSaveCallback.htm#apex_class_DataSource_AsyncSaveCallback
    /// </summary>
    public class AsyncSaveCallback
    {
        // infrastructure
        public AsyncSaveCallback(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(AsyncSaveCallback));
            }
        }

        // API
        public void processSave(SaveResult saveResult)
        {
            Self.processSave(saveResult);
        }
    }
}
