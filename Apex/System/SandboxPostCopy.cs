namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_System_SandboxPostCopy.htm#apex_interface_System_SandboxPostCopy
    /// </summary>
    public interface SandboxPostCopy
    {
        void runApexClass(SandboxContext context);
    }
}
