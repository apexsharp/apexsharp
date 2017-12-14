namespace DemoVs2017.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.ApexSharp.NUnit;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [TestFixture]
    public class DemoControllerTests
    {
        [Test]
        static void testConstructor()
        {
        }

        [Test]
        static void testGetAppVersion()
        {
            DemoController demo = new DemoController();
        }
    }
}
