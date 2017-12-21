namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [TestFixture]
    public class DemoTest
    {
        [Test]
        public static void updatePhoneTestValidEmail()
        {
            Contact contact = new Contact();
            contact.Email = randomWithLimit()+ "@jay.com";
            contact.Phone = "111-111=1111";
            contact.LastName = "jay";
            Soql.insert(contact);
            Demo.updatePhone(contact.Email, "555-1212");
            List<Contact> contacts = Soql.query<Contact>("SELECT ID, Email, Phone FROM Contact WHERE Email = :contact.Email", contact.Email);
            System.assertEquals(contacts[0].Phone, "555-1212");
        }

        [Test]
        public static void updatePhoneTestNotValidEmail()
        {
            Contact contact = new Contact();
            contact.Email = randomWithLimit()+ "@jay.com";
            contact.Phone = "111-111=1111";
            contact.LastName = "jay";
            Soql.insert(contact);
            Demo.updatePhone(contact.Email, "555-1212");
            List<Contact> contacts = Soql.query<Contact>("SELECT ID, Email, Phone FROM Contact WHERE Email = '@jay.com'");
            System.assertEquals(contacts.size(), 0);
        }

        [Test]
        public static void getContactsTest()
        {
            Contact contact = new Contact();
            contact.Email = randomWithLimit()+ "@jay.com";
            contact.Phone = "111-111=1111";
            contact.LastName = "jay";
            Soql.insert(contact);
            List<Contact> contacts = Demo.getContacts();
            System.assert(contacts.size()> 0);
        }

        public static int randomWithLimit()
        {
            double randomNumber = Math.random();
            return Math.round(randomNumber * 1000000);
        }
    }
}
