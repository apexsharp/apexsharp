@IsTest
public class ClassRestTest
{
    @IsTest
    public static void PostTest()
    {
        RestContext.request = new RestRequest();
        RestContext.response = new RestResponse();
        ClassRest.ContactDTO contact = new ClassRest.ContactDTO();
        contact.LastName = 'LastName';
        RestContext.request.requestBody = Blob.valueOf(JSON.serialize(contact));
        ClassRest.post();
        System.assertEquals(200, RestContext.response.statusCode);
        List<Contact> contacts = [SELECT Id FROM Contact WHERE LastName = 'LastName'];
        System.assertEquals(1, contacts.size());
    }
}
