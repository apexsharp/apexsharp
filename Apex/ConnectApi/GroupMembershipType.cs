namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum GroupMembershipType
    {
        GroupManager,
        GroupOwner,
        NotAMember,
        NotAMemberPrivateRequested,
        StandardMember
    }
}
