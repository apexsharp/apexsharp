namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using SObjects;

    [TestFixture]
    public class DemoControllerTests
    {
        [Test]
        public static void testConstructor()
        {
        }

        [Test]
        public static void testGetAppVersion()
        {
            DemoController demo = new DemoController();
        }
    }
}
