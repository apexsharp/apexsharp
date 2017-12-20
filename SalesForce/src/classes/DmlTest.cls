public class DmlTest
{
    public static void UpsertTest()
    {
        Contact contactNew = new Contact();
        contactNew.LastName = 'apexSharp';
        contactNew.Email = 'abc@abc.com';
        upsert contactNew;
        System.debug(contactNew.Id);
        List<Contact> contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts)
        {
            System.debug(c.Email);
            c.Email = 'new@new.com';
        }

        upsert contacts;
        contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts)
        {
            System.debug(c.Email);
        }
    }
}
