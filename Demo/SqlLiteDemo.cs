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
        public static void SqlLiteInsert()
        {
            OrmLiteConfig.DialectProvider = SqliteDialect.Provider;
            using (IDbConnection db = "db.sqlite".OpenDbConnection())
            {
                db.CreateTable<Account>(true);

                List<Account> accountList = SoqlApi.Query<Account>(5);

                db.InsertAll(accountList);

                var account = db.Select<Account>(x => x.Id == "0013600000Vm91zAAB").FirstOrDefault();
                Console.WriteLine(account.Dump());
            }
        }

        public static void InsertIntoSalesForce()
        {
            OrmLiteConfig.DialectProvider = SqliteDialect.Provider;
            using (IDbConnection db = "db.sqlite".OpenDbConnection())
            {

                var account = db.Select<Account>(x => x.Id == "0013600000Vm91zAAB").FirstOrDefault();

                SoqlApi.Upsert(account);
                

                Console.WriteLine(account.Dump());
            }
        }
    }
}
