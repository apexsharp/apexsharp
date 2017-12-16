namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_Metadata_DeployProblemType.htm
    /// </summary>
    public enum DeployProblemType
    {
        Error,
        Warning
    }
}
