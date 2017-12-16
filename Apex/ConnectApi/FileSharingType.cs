namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum FileSharingType
    {
        Admin,
        Collaborator,
        Owner,
        Viewer,
        WorkspaceManaged
    }
}
