public class SoqlDemo {
/**
 * A simple CRUD Example
 */
    public static void CrudExample() {
        // Contact contactNew = new Contact(LastName = 'Jay', Email = 'abc@abc.com');
        Contact contactNew = new Contact();
        insert contactNew;

        System.Debug(contactNew.Id);

        List<Contact> contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts) {
            System.Debug(c.Email);
            c.Email = 'new@new.com';
        }
        update contacts;

        contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        for (Contact c : contacts) {
            System.Debug(c.Email);
        }
        delete contacts;

        contacts = [SELECT Id, Email FROM Contact WHERE Id = :contactNew.Id];
        if (contacts.IsEmpty()) {
            System.Debug('Delete Worked');
        }
    }

    public static void OneVsListDemo() {
        List<Contact> contacts = [SELECT Id, Email FROM Contact LIMIT 5];
        List<Contact> contact = [SELECT Id, Email FROM Contact LIMIT 1];
    }

    public static void VariableScope(Integer x) {
        if (x == 5) {
            List<Contact> objectList;
            objectList = [SELECT Id FROM Contact LIMIT 5];
        } else {
            List<Contact> objectList;
            objectList = [SELECT Id FROM Contact LIMIT 5];
        }
    }

    public static void InClauseTest() {
        Contact[] contactList = [SELECT Id, Email, Phone FROM Contact WHERE Email IN ('rose@edge.com', 'sean@edge.com')];

        string[] emails = new String[]{
                'rose@edge.com', 'sean@edge.com'
        };
        Contact[] contactListThree = [SELECT Id, Email, Phone FROM Contact WHERE Email IN :emails];

        Contact[] contactListOne = [SELECT Id, Email FROM Contact LIMIT 2];
        Contact[] contactListTwo = [SELECT Id FROM Contact WHERE Id IN :contactListOne];
    }

    public static void ForSoql()
    {
        for(Contact contactList : [SELECT Id, Name FROM Contact]) {

        }
    }
}