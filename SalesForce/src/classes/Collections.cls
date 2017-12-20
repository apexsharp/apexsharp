public with sharing class Collections
{
    // public List<String> StringList = new List<String>{'one', 'two'};
    public Integer[] IntegerArray = new Integer[]{1, 2, 3};

    public void arrayDemo()
    {
        // List<String> stringListLocal = new List<String>{'one', 'two'};
        Integer[] integerArrayLocal = new Integer[]{1, 2, 3};
    }

    public void listExample()
    {
        List<Integer> myList = new List<Integer>();
        myList.add(47);
        Integer i = myList.get(0);
        myList.set(0, 1);
        myList.clear();
        List<SelectOption> options = new List<SelectOption>();
        options.add(new SelectOption('A','United States'));
        options.add(new SelectOption('C','Canada'));
        options.add(new SelectOption('A','Mexico'));
        System.debug('Before sorting: '+ options);
        options.sort();
        System.debug('After sorting: '+ options);
    }

    public void setExample()
    {
        Set<Integer> s = new Set<Integer>();
        s.add(1);
        s.remove(1);
    }

    public void mapExample()
    {
        Map<Integer, String> m = new Map<Integer, String>();
        m.put(1, 'First entry');
        m.put(2, 'Second entry');
        String value = m.get(2);
    }

    public void mapSoqlExample()
    {
        // Map<Id, Contact> m = new Map<Id, Contact>(Soql.Query<Contact>("SELECT Id FROM Jay__c"));
        Map<ID, Contact> m = new Map<ID, Contact>([SELECT Id, Name FROM Contact LIMIT 10]);
        for (ID idKey : m.keySet())
        {
            Contact contact = m.get(idKey);
        }
    }
}
