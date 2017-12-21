namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using SObjects;

    [TestFixture]
    public class GetPutDemoTest
    {
        [Test]
        public static void GetTest()
        {
            Account acc = new Account { Name = "Acme", Description = "Acme Account" };
            string description = (string)acc.get("Description");
            System.assertEquals("Acme Account", description);
        }

        [Test]
        public static void PutTest()
        {
            Account acc = new Account { Name = "test", Description = "old desc" };
            string oldDesc = (string)acc.put("description", "new desc");
            System.assertEquals("old desc", oldDesc);
            System.assertEquals("new desc", acc.Description);
        }
    }
}
