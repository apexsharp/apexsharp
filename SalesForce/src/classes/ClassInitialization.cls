public class ClassInitialization
{
    public List<Contact> contactList;

    public ClassInitialization()
    {
        contactList = [SELECT ID FROM Contact LIMIT 1];
    }

    public static Map<String, String> colorMap = new Map<String, String>();

    static
    {
        colorMap.put('red', '255, 0, 0');
        colorMap.put('cyan', '0, 255, 255');
        colorMap.put('magenta', '255, 0, 255');
    }
}
