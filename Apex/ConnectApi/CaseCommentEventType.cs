namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum CaseCommentEventType
    {
        NewInternal,
        NewPublished,
        NewPublishedByCustomer,
        PublishExisting,
        PublishExistingByCustomer,
        UnpublishExistingByCustomer,
        UnpublishExsiting
    }
}
