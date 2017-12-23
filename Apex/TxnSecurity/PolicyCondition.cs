namespace Apex.TxnSecurity
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_TxnSecurity_PolicyCondition.htm#apex_interface_TxnSecurity_PolicyCondition
    /// </summary>
    public interface PolicyCondition
    {
        bool evaluate(Event @event);
    }
}
