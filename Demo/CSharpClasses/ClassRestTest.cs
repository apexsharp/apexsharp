namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;

    using SObjects;

    [TestFixture]
    public class ClassRestTest
    {
        [Test]
        public static void PostTest()
        {
            RestContext.request = new RestRequest();
            RestContext.response = new RestResponse();
            ClassRest.ContactDTO contact = new ClassRest.ContactDTO();
            contact.LastName = "LastName";
            RestContext.request.RequestBody = Blob.valueOf(JSON.serialize(contact));
            ClassRest.post();
            System.assertEquals(200, RestContext.Response.StatusCode);
            List<Contact> contacts = Soql.query<Contact>("SELECT Id FROM Contact WHERE LastName = 'LastName'");
            System.assertEquals(1, contacts.size());
        }
    }
}
