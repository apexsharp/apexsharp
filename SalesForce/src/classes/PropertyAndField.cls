public class PropertyAndField
{
    public Datetime DateTimeGetSet { get; set; }

    public List<Datetime> DateTimeGetSetGeneric { get; set; }

    public Datetime[] DateTimeGetSetArray { get; set; }

    public Datetime DateTimeEmpty;

    public Datetime DateTimeInitialized = Datetime.now();

    public List<Datetime> DateTimeList = new List<Datetime>();

    public Datetime[] DateTimeArray = new Datetime[5];

    public String Name = 'jay';

    public final String nameFinal = 'jay';

    public static String NameStatic = 'jay';

    public static final String NameStaticFinal = 'jay';

    public List<Contact> ContactList = [SELECT Id, Email FROM Contact];

    public Set<String> stringSet = new Set<String>{};

    public Boolean shouldRedirect { get; set; }

    public String[] newStringArray = new String[]{'Hi'};

    public void MethodOne()
    {
        Datetime dateTimeEmpty;
        dateTimeEmpty = Datetime.now();
        Datetime dateTimeInitilized = Datetime.now();
        List<Datetime> dateTimeList = new List<Datetime>();
        Datetime[] dateTimeArrary = new Datetime[5];
        String name;
        name = 'Jay';
    }
}
