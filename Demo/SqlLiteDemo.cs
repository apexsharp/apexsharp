using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Apex.ApexSharp;
using Demo.SObjects;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace Demo
{
    public class SqlLiteDemo
    {
        public static void ParentChildRead()
        {

            OrmLiteConfig.DialectProvider = SqliteDialect.Provider;
            using (IDbConnection db = "db.sqlite".OpenDbConnection())
            {
                db.CreateTable<AccountType__c>(true);
                db.CreateTable<BankAccount__c>(true);
                db.CreateTable<Customer__c>(true);

                List<AccountType__c> accountTypeList = SoqlApi.Query<AccountType__c>(1);
                db.InsertAll(accountTypeList);

                var accountTypes = db.Select<AccountType__c>();
                foreach (var accountTypeC in accountTypes)
                {
                    var bankAccount = SoqlApi.QueryById<BankAccount__c>(accountTypeC.BankAccount__c);
                    db.Insert(bankAccount);


                    var bankAccounts = db.Select<BankAccount__c>();
                    foreach (var bankAccountC in bankAccounts)
                    {
                        var customer = SoqlApi.QueryById<Customer__c>(bankAccountC.Customer__c);
                        db.Insert(customer);
                    }
                }
            }
        }

        public static void SqlReadAndInsert()
        {
            OrmLiteConfig.DialectProvider = SqliteDialect.Provider;
            using (IDbConnection db = "db.sqlite".OpenDbConnection())
            {
                db.CreateTable<AccountType__c>(true);
                db.CreateTable<BankAccount__c>(true);
                db.CreateTable<Customer__c>(true);
                
                List<AccountType__c> accountTypeList = SoqlApi.Query<AccountType__c>(1);
                db.InsertAll(accountTypeList);

                var accountTypes = db.Select<AccountType__c>();
                foreach (var accountTypeC in accountTypes)
                {
                    var bankAccount = SoqlApi.QueryById<BankAccount__c>(accountTypeC.BankAccount__c);
                    db.Insert(bankAccount);


                    var bankAccounts = db.Select<BankAccount__c>();
                    foreach (var bankAccountC in bankAccounts)
                    {
                        var customer = SoqlApi.QueryById<Customer__c>(bankAccountC.Customer__c);
                        db.Insert(customer);
                    }
                }



                //List<Customer__c> customerList = SoqlApi.Query<Customer__c>(10);
                //db.InsertAll(customerList);

                //var account = db.Select<Account>(x => x.Name == accountList[0].Name).FirstOrDefault();
                //Console.WriteLine(account.Dump());

                //Soql.Update(account);
                //account = Soql.query<Account>("SELECT Id, Name FROM Account WHERE Name = :account.Name", account.Name);
                //Console.WriteLine(account.Dump());
            }
        }

        private static void CreateAllTables(IDbConnection db, bool overwrite)
        {
            CreateTables(db, null, overwrite);
        }

        private static void CreateTables(IDbConnection db, string[] classNames, bool overwrite)
        {
            //// let's say that table types are all defined
            //// in the same assembly and namespace as Account type
            //var tableTypes =
            //    from type in typeof(Account).Assembly.GetTypes()
            //    where type.Namespace == typeof(Account).Namespace
            //    select type;

            //// filter out the unneeded types as needed
            //if (classNames != null && classNames.Any())
            //{
            //    tableTypes = tableTypes.Where(t => classNames.Contains(t.Name));
            //}

            //// create all tables
            //foreach (var type in tableTypes)
            //{
            //    db.CreateTable(overwrite, type);
            //}
        }
    }
}
