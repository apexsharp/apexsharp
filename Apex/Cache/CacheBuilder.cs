namespace Apex.Cache
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_cache_CacheBuilder.htm#apex_interface_cache_CacheBuilder
    /// </summary>
    public interface CacheBuilder
    {
        object doLoad(string var);
    }
}
