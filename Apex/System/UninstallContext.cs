namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface UninstallContext
    {
        ID organizationId();

        ID uninstallerId();
    }
}
