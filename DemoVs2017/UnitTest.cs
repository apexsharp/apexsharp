namespace DemoVs2017
{
    using Apex.ApexSharp.NUnit;
    using Apex.System;

    [TestFixture]
    public class UnitTest
    {
        [SetUp]
        public static void setup()
        {
            System.debug("Class Setup Called");
        }

        [Test]
        public static void assert()
        {
            System.assert(true, "Assert True");
        }
    }
}
