namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using SObjects;

    [TestFixture]
    public class DmlTest
    {
        [Test]
        public static void UpsertTest()
        {
            Contact contactNew = new Contact();
            contactNew.LastName = "apexSharp" + Math.random();
            contactNew.Email = Math.random() + "abc@abc.com";
            Soql.upsert(contactNew);
            System.debug(contactNew.Id);
            List<Contact> contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
                c.Email = "new@new.com";
            }

            Soql.upsert(contactNew);
            contacts = Soql.query<Contact>("SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id", contactNew.Id);
            foreach (Contact c in contacts)
            {
                System.debug(c.Email);
            }
        }
    }
}
