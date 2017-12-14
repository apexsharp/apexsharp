namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class PropertyAndField
    {
        public DateTime DateTimeGetSet { get; set; }

        public List<DateTime> DateTimeGetSetGeneric { get; set; }

        public DateTime[] DateTimeGetSetArray { get; set; }

        public DateTime DateTimeEmpty;

        public DateTime DateTimeInitialized = DateTime.now();

        public List<DateTime> DateTimeList = new List<DateTime>();

        public DateTime[] DateTimeArray = new DateTime[5];

        public string Name = "jay";

        public readonly string nameFinal = "jay";

        public static string NameStatic = "jay";

        public static readonly string NameStaticFinal = "jay";

        public List<Contact> ContactList = Soql.query<Contact>("SELECT Id, Email FROM Contact");

        public Set<string> stringSet = new Set<string>{};

        public bool shouldRedirect { get; set; }

        public string[] newStringArray = new string[]{"Hi"};

        public void MethodOne()
        {
            DateTime dateTimeEmpty;
            dateTimeEmpty = DateTime.now();
            DateTime dateTimeInitilized = DateTime.now();
            List<DateTime> dateTimeList = new List<DateTime>();
            DateTime[] dateTimeArrary = new DateTime[5];
            string name;
            name = "Jay";
        }
    }
}
