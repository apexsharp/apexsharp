using System;
using System.Collections.Generic;
using System.Text;
using Apex.ApexSharp;
using Demo.SObjects;

namespace Demo.CSharpClasses
{
    public class SoqlParentChild
    {
        public static void ParentChildDemo()
        {
            List<BankAccount__c> bankAccounts = Soql.Query<BankAccount__c>("SELECT Name, Customer__r.Name FROM BankAccount__C LIMIT 1");
            Console.WriteLine(bankAccounts[0].Customer__r.Name);

        }
    }
}
