namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum WorkflowProcessStatus
    {
        Approved,
        Fault,
        Held,
        NoResponse,
        Pending,
        Reassigned,
        Rejected,
        Removed,
        Started
    }
}
