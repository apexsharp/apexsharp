namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_comparable.htm#apex_comparable
    /// </summary>
    public interface Comparable
    {
        int compareTo(object objectToCompareTo);
    }
}
