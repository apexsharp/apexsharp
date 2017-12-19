@IsTest
public class DemoTest
{
    @IsTest
    public static void updatePhoneTestValidEmail()
    {
        Contact contact = new Contact();
        contact.Email = randomWithLimit()+ '@jay.com';
        contact.Phone = '111-111=1111';
        contact.LastName = 'jay';
        insert contact;
        Demo.updatePhone(contact.Email, '555-1212');
        List<Contact> contacts = [SELECT ID, Email, Phone FROM Contact WHERE Email = :contact.Email];
        System.assertEquals(contacts[0].Phone, '555-1212');
    }

    @IsTest
    public static void updatePhoneTestNotValidEmail()
    {
        Contact contact = new Contact();
        contact.Email = randomWithLimit()+ '@jay.com';
        contact.Phone = '111-111=1111';
        contact.LastName = 'jay';
        insert contact;
        Demo.updatePhone(contact.Email, '555-1212');
        List<Contact> contacts = [SELECT ID, Email, Phone FROM Contact WHERE Email = '@jay.com'];
        System.assertEquals(contacts.size(), 0);
    }

    @IsTest
    public static void getContactsTest()
    {
        Contact contact = new Contact();
        contact.Email = randomWithLimit()+ '@jay.com';
        contact.Phone = '111-111=1111';
        contact.LastName = 'jay';
        insert contact;
        List<Contact> contacts = Demo.getContacts();
        System.assert(contacts.size()> 0);
    }

    public static Double randomWithLimit()
    {
        Double randomNumber = Math.random();
        return randomNumber;
    }
}
