namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [WithSharing]
    public class ClassAuraEnabled
    {
        [AuraEnabled]
        public string label { get; set; }

        [AuraEnabled]
        public static void setInteger(int myInteger)
        {
            System.debug(myInteger);
        }
    }
}
