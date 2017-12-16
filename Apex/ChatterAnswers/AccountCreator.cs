namespace Apex.ChatterAnswers
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_interface_chatteranswers_accountcreator.htm#apex_interface_chatteranswers_accountcreator
    /// </summary>
    public interface AccountCreator
    {
        string createAccount(string firstName, string lastName, ID siteAdminId);
    }
}
