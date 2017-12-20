namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    
    using SObjects;

    [TestFixture]
    [WithSharing]
    public class RunAll
    {
        [Test]
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
            ClassNoApex.methodTwo("Apex");
            System.debug(new ClassUnitTestSeeAllData());
            System.debug(new ClassWithOutSharing());
            System.debug(new ClassWithSharing());
        }
    }
}
