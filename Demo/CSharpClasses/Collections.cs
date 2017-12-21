namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [WithSharing]
    public class Collections
    {
        public List<string> StringList = new List<string>{"one", "two"};

        public int[] IntegerArray = new int[]{1, 2, 3};

        public void arrayDemo()
        {
            List<string> stringListLocal = new List<string>{"one", "two"};
            int[] integerArrayLocal = new int[]{1, 2, 3};
        }

        public void listExample()
        {
            List<int> myList = new List<int>();
            myList.add(47);
            int i = myList.get(0);
            myList.set(0, 1);
            myList.clear();
            List<SelectOption> options = new List<SelectOption>();
            options.add(new SelectOption("A","United States"));
            options.add(new SelectOption("C","Canada"));
            options.add(new SelectOption("A","Mexico"));
            System.debug("Before sorting: "+ options);
            options.sort();
            System.debug("After sorting: "+ options);
        }

        public void setExample()
        {
            Set<int> s = new Set<int>();
            s.add(1);
            s.remove(1);
        }

        public void mapExample()
        {
            Map<int, string> m = new Map<int, string>();
            m.put(1, "First entry");
            m.put(2, "Second entry");
            string value = m.get(2);
        }

        public void mapSoqlExample()
        {
            Map<ID, Contact> m = new Map<ID, Contact>(Soql.query<Contact>("SELECT Id, Name FROM Contact LIMIT 10"));
            foreach (ID idKey in m.keySet())
            {
                Contact contact = m.get(idKey);
            }
        }
    }
}
