namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class ClassUnitTestRunAs
    {
        static void RunAsExample()
        {
            User newUser = Soql.query<User>("SELECT Id FROM User LIMIT 1");
            // ToDo
            //using (System.runAs(newUser))
            //{
            //}
        }
    }
}
