namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_database_batchablecontext.htm#apex_interface_database_batchablecontext
    /// </summary>
    public interface BatchableContext
    {
        ID getChildJobId();

        ID getJobId();
    }
}
