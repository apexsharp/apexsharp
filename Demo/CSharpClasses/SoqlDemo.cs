namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class SoqlDemo
    {
        /**
         * A simple CRUD Example
         */
        public static void crudExample()
        {
            // Contact contactNew = new Contact(LastName = 'Jay', Email = 'abc@abc.com');
            Contact contactNew = new Contact();
            Soql.Insert(contactNew);
            System.debug(contactNew.Id);
            List<Contact> contacts = Soql.Query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
                c.Email = "new@new.com";
            }

            Soql.Update(contacts);
            contacts = Soql.Query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
            }

            Soql.Delete(contacts);
            contacts = Soql.Query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            if (contacts.isEmpty())
            {
                System.debug("Delete Worked");
            }
        }

        public static void oneVsListDemo()
        {
            List<Contact> contacts = Soql.Query<Contact>("SELECT Id, Email FROM Contact LIMIT 5");
            List<Contact> contact = Soql.Query<Contact>("SELECT Id, Email FROM Contact LIMIT 1");
        }

        public static void variableScope(int x)
        {
            if (x == 5)
            {
                List<Contact> objectList;
                objectList = Soql.Query<Contact>("SELECT Id FROM Contact LIMIT 5");
            }
            else
            {
                List<Contact> objectList;
                objectList = Soql.Query<Contact>("SELECT Id FROM Contact LIMIT 5");
            }
        }

        public static void inClauseTest()
        {
            Contact[] contactList = Soql.Query<Contact>("SELECT Id, Email, Phone FROM Contact WHERE Email IN ('rose@edge.com', 'sean@edge.com')");
            string[] emails = new string[]{"rose@edge.com", "sean@edge.com"};
            Contact[] contactListThree = Soql.Query<Contact>("SELECT Id, Email, Phone FROM Contact WHERE Email IN :emails", emails);
            Contact[] contactListOne = Soql.Query<Contact>("SELECT Id, Email FROM Contact LIMIT 2");
            Contact[] contactListTwo = Soql.Query<Contact>("SELECT Id FROM Contact WHERE Id IN :contactListOne", contactListOne);
        }

        public static void forSoql()
        {
            foreach (Contact contactList in Soql.Query<Contact>("SELECT Id, Name FROM Contact"))
            {
            }
        }
    }
}
