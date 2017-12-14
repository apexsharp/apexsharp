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
        [SetUp]
        public static void setup()
        {
            Contact contactNew = new Contact();
            contactNew.LastName = "Jay";
            contactNew.Email = "jay@jay.com";
            Soql.insert(contactNew);
        }

        [Test]
        public static void updatePhoneTestValidEmail()
        {
            Demo.updatePhone("jay@jay.com", "555-1212");
            List<Contact> contacts = Soql.query<Contact>("SELECT ID, Email, Phone FROM Contact WHERE Email = 'jay@jay.com'");
            System.assertEquals(contacts[0].Phone, "555-1212");
        }

        [Test]
        public static void updatePhoneTestNotValidEmail()
        {
            Demo.updatePhone("nojay@jay.com", "555-1212");
            List<Contact> contacts = Soql.query<Contact>("SELECT ID, Email, Phone FROM Contact WHERE Email = 'nojay@jay.com'");
            System.assertEquals(contacts.size(), 0);
        }
    }
}
