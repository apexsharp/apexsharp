namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;

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
                RestContext x;
                ContactDTO contact = (ContactDTO)JSON.deserialize(RestContext.request.RequestBody.ToString(), typeof(ContactDTO));
                insertContact(contact);
                RestContext.response.StatusCode = 200;
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
