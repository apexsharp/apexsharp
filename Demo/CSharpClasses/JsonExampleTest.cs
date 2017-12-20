namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [TestFixture]
    public class JsonExampleTest
    {
        [Test]
        public static void JsonExampleMethod()
        {
            Contact contact = new Contact();
            contact.LastName = "Jay";
            contact.Email = "jay@jay.com";
            string jsonString = JSON.serialize(contact);
            // Todo
            // Contact newContact = (Contact)JSON.deserialize(jsonString, typeof(Contact));
            // System.assertEquals("jay@jay.com", newContact.Email);
        }
    }
}
