public class SoqlDemo
{
    /**
    * A simple CRUD Example
     */
    public static void crudExample()
    {
        // Contact contactNew = new Contact(LastName = 'Jay', Email = 'abc@abc.com');
        Contact contactNew = new Contact();
        insert contactNew;
        System.debug(contactNew.Id);
        List<Contact> contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts)
        {
            System.debug(c.Email);
            c.Email = 'new@new.com';
        }

        update contacts;
        contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts)
        {
            System.debug(c.Email);
        }

        delete contacts;
        contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        if (contacts.isEmpty())
        {
            System.debug('Delete Worked');
        }
    }

    public static void oneVsListDemo()
    {
        List<Contact> contacts = [SELECT Id, Email FROM Contact LIMIT 5];
        List<Contact> contact = [SELECT Id, Email FROM Contact LIMIT 1];
    }

    public static void variableScope(Integer x)
    {
        if (x == 5)
        {
            List<Contact> objectList;
            objectList = [SELECT Id FROM Contact LIMIT 5];
        }
        else
        {
            List<Contact> objectList;
            objectList = [SELECT Id FROM Contact LIMIT 5];
        }
    }

    public static void inClauseTest()
    {
        Contact[] contactList = [SELECT Id, Email, Phone FROM Contact WHERE Email IN ('rose@edge.com', 'sean@edge.com')];
        String[] emails = new String[]{'rose@edge.com', 'sean@edge.com'};
        Contact[] contactListThree = [SELECT Id, Email, Phone FROM Contact WHERE Email IN :emails];
        Contact[] contactListOne = [SELECT Id, Email FROM Contact LIMIT 2];
        Contact[] contactListTwo = [SELECT Id FROM Contact WHERE Id IN :contactListOne];
    }

    public static void forSoql()
    {
        for (Contact contactList : [SELECT Id, Name FROM Contact])
        {
        }
    }
}
