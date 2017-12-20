@IsTest
public with sharing class RunAll
{
    @IsTest
    public static void TestClassess()
    {
        System.debug(ClassEnum.America);
        System.debug(new ClassException());
        System.debug(new ClassGlobal());
        ClassInitialization newClassInitialization = new ClassInitialization();
        System.debug(ClassInitialization.colorMap);
        System.debug(newClassInitialization.contactList);
        ClassInterface classInterface = new ClassInterface();
        System.debug(classInterface.getName());
        System.debug(new ClassInternal.InternalClassOne());
        System.debug(new ClassInternal.InternalClassTwo());
        ClassNoApex.methodTwo('Apex');
        System.debug(new ClassUnitTestSeeAllData());
        System.debug(new ClassWithOutSharing());
        System.debug(new ClassWithSharing());
    }
}
