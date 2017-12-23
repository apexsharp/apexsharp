namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum DeployStatus
    {
        Canceled,
        Canceling,
        Failed,
        InProgress,
        Pending,
        Succeeded,
        SucceededPartial
    }
}
