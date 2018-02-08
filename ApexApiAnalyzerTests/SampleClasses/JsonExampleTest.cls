@IsTest
public class JsonExampleTest {
    @IsTest
    public static void JsonExampleMethod()
    {
        Contact contact = new Contact();
        contact.LastName = 'Jay';
        contact.Email = 'jay@jay.com';

        String jsonString = JSON.serialize(contact);
        Contact newContact = (Contact)JSON.deserialize(jsonString, Contact.class);

        System.assertEquals('jay@jay.com', newContact.Email);
    }
}