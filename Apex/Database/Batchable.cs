namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_database_batchable.htm#apex_interface_database_batchable
    /// </summary>
    public interface Batchable
    {
        void execute(BatchableContext jobId, List<SObject> recordList);

        void finish(BatchableContext jobId);

        Iterable start(BatchableContext jobId);
    }
}
