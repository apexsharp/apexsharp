namespace DemoVs2017.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [RestResource(urlMapping="/api/RestDemo")]
    [Global]
    public class ClassRest
    {
        public class ContactDTO
        {
            public string LastName { get; set; }
        }

        [HttpPost]
        [Global]
        public static void post()
        {
            try
            {
                ContactDTO contact = (ContactDTO)JSON.deserialize(RestContext.Request.RequestBody.ToString(), typeof(ContactDTO));
                insertContact(contact);
                RestContext.Response.StatusCode = 200;
            }
            catch (Exception e)
            {
                RestContext.Response.StatusCode = 500;
            }
        }

        public static void insertContact(ContactDTO contactToSave)
        {
            Contact contact = new Contact();
            contact.LastName = contactToSave.LastName;
            Soql.insert(contact);
        }

        [HttpGet]
        [Global]
        public static string get()
        {
            return "Jay";
        }

        [HttpPatch]
        [Global]
        public static void patch()
        {
        }

        [HttpPut]
        [Global]
        public static void put()
        {
        }

        [HttpDelete]
        [Global]
        public static void doDelete()
        {
        }
    }
}
