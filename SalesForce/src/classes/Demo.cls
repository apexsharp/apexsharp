public class Demo
{
    public Contact contact { get; set; }

    public Demo()
    {
        contact = new Contact();
    }

    public PageReference save()
    {
        try
        {
            insert contact;
        }
        catch (DmlException e)
        {
            ApexPages.addMessages(e);
        }

        return null;
    }

    public static String updatePhone(String email, String newPhone)
    {
        List<Contact> contacts = getContactByEMail(email);
        if (contacts.isEmpty())
        {
            return 'Not Found';
        }
        else
        {
            contacts[0].Phone = newPhone;
            updateContacts(contacts);
            return 'Phone Number Updated';
        }
    }

    public static List<Contact> getContactByEMail(String email)
    {
        List<Contact> contacts = [SELECT Id, Email, Phone FROM Contact WHERE Email = :email];
        return contacts;
    }

    public static List<Contact> getContacts()
    {
        List<Contact> contacts = [SELECT Id, Email, Phone FROM Contact];
        return contacts;

        //:NoApex NoApex.Serilog.LogInfo(contacts.size().ToString());
    }

    public static void updateContacts(List<Contact> contacts)
    {
        update contacts;
    }
}
