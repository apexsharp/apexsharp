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
        public static void SqlReadAndInsert()
        {
            OrmLiteConfig.DialectProvider = SqliteDialect.Provider;
            using (IDbConnection db = "db.sqlite".OpenDbConnection())
            {
                db.CreateTable<Account>(true);

                //CreateAllTables(db, true);

                List<Account> accountList = SoqlApi.Query<Account>(1);
                Console.WriteLine(accountList[0].Dump());

                accountList[0].Name = Guid.NewGuid().ToString();
                db.InsertAll(accountList);

                var account = db.Select<Account>(x => x.Name == accountList[0].Name).FirstOrDefault();
                Console.WriteLine(account.Dump());

                Soql.Update(account);
                account = Soql.query<Account>("SELECT Id, Name FROM Account WHERE Name = :account.Name", account.Name);
                Console.WriteLine(account.Dump());
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
