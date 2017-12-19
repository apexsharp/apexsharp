public class JsonExample
{
    public void JsonExampleMethod()
    {
        Contact contact = new Contact();
        contact.LastName = 'Jay';
        contact.Email = 'jay@jay.com';
        String jsonString = JSON.serialize(contact);
        Contact newContact = (Contact)JSON.deserialize(jsonString, String.class);
    }
}
