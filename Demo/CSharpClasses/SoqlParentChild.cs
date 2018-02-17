using System;
using System.Collections.Generic;
using System.Text;
using Apex.ApexSharp;
using Demo.SObjects;
using ServiceStack.Text;

namespace Demo.CSharpClasses
{
    public class SoqlParentChild
    {
        public static void ParentChildDemo()
        {
            List<AccountType__c> accountTypes = Soql.Query<AccountType__c>("SELECT BankAccountType__c, 	BankAccount__r.Name, BankAccount__r.Customer__r.Name FROM AccountType__c LIMIT 1");
            Console.WriteLine(accountTypes[0].BankAccount__r.Customer__r.Name);
        }
    }
}
