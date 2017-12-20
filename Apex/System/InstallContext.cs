namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public interface InstallContext
    {
        ID installerId();

        bool isPush();

        bool isUpgrade();

        ID organizationId();

        Version previousVersion();
    }
}
