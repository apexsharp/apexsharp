public with sharing class MethodComplex
{
    public static void methodOne()
    {
        for (Account a : [SELECT Id FROM Account])
        {
            System.debug(a.Id);
        }

        for (Integer i = 0; i<10; i++)
        {
        }
    }

    public Database.QueryLocator queryLocator(Database.BatchableContext bc)
    {
        return Database.getQueryLocator([SELECT Id FROM Contact]);
    }
}