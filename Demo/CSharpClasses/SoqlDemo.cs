namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    
    using SObjects;

    public class SoqlDemo
    {
        /**
         * A simple CRUD Example
         */
        public static void CrudExample()
        {
            // Contact contactNew = new Contact(LastName = 'Jay', Email = 'abc@abc.com');
            Contact contactNew = new Contact();
            Soql.insert(contactNew);
            System.debug(contactNew.Id);
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
                c.Email = "new@new.com";
            }

            Soql.update(contacts);
            contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
            }

            Soql.delete(contacts);
            contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            if (contacts.isEmpty())
            {
                System.debug("Delete Worked");
            }
        }

        public static void OneVsListDemo()
        {
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact LIMIT 5");
            List<Contact> contact = Soql.query<Contact>("SELECT Id, Email FROM Contact LIMIT 1");
        }

        public static void VariableScope(int x)
        {
            if (x == 5)
            {
                List<Contact> objectList;
                objectList = Soql.query<Contact>("SELECT Id FROM Contact LIMIT 5");
            }
            else
            {
                List<Contact> objectList;
                objectList = Soql.query<Contact>("SELECT Id FROM Contact LIMIT 5");
            }
        }

        public static void InClauseTest()
        {
            Contact[] contactList = Soql.query<Contact>("SELECT Id, Email, Phone FROM Contact WHERE Email IN ('rose@edge.com', 'sean@edge.com')");
            string[] emails = new string[]{"rose@edge.com", "sean@edge.com"};
            Contact[] contactListThree = Soql.query<Contact>("SELECT Id, Email, Phone FROM Contact WHERE Email IN :emails", emails);
            Contact[] contactListOne = Soql.query<Contact>("SELECT Id, Email FROM Contact LIMIT 2");
            Contact[] contactListTwo = Soql.query<Contact>("SELECT Id FROM Contact WHERE Id IN :contactListOne", contactListOne);
        }

        public static void ForSoql()
        {
            foreach (Contact contactList in Soql.query<Contact>("SELECT Id, Name FROM Contact"))
            {
            }
        }
    }
}
