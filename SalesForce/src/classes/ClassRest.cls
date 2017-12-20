@RestResource(urlMapping='/api/RestDemo')
global class ClassRest
{
    public class ContactDTO
    {
        public String LastName { get; set; }
    }

    @HttpPost
    global static void post()
    {
        try
        {
            ContactDTO contact = (ContactDTO)JSON.deserialize(RestContext.request.requestBody.toString(), ContactDTO.class);
            insertContact(contact);
            RestContext.response.statusCode = 200;
        }
        catch (Exception e)
        {
            RestContext.response.statusCode = 500;
        }
    }

    public static void insertContact(ContactDTO contactToSave)
    {
        Contact contact = new Contact();
        contact.LastName = contactToSave.LastName;
        insert contact;
    }

    @HttpGet
    global static String get()
    {
        return 'Jay';
    }

    @HttpPatch
    global static void patch()
    {
    }

    @HttpPut
    global static void put()
    {
    }

    @HttpDelete
    global static void doDelete()
    {
    }
}
