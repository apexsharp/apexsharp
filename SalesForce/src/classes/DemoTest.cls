@IsTest
public class DemoTest
{
    @TestSetup
    public static void setup()
    {
        Contact contactNew = new Contact();
        contactNew.LastName = 'Jay';
        contactNew.Email = 'jay@jay.com';
        insert contactNew;
    }

    @IsTest
    public static void updatePhoneTestValidEmail()
    {
        Demo.updatePhone('jay@jay.com', '555-1212');
        List<Contact> contacts = [SELECT ID, Email, Phone FROM Contact WHERE Email = 'jay@jay.com'];
        System.assertEquals(contacts[0].Phone, '555-1212');
    }

    @IsTest
    public static void updatePhoneTestNotValidEmail()
    {
        Demo.updatePhone('nojay@jay.com', '555-1212');
        List<Contact> contacts = [SELECT ID, Email, Phone FROM Contact WHERE Email = 'nojay@jay.com'];
        System.assertEquals(contacts.size(), 0);
    }
}
