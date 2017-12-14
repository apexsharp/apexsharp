namespace DemoVs2017
{
    using Apex.ApexSharp.NUnit;

    [TestFixture]
    public class UnitTest
    {
        [SetUp]
        public static void setup()
        {
            Apex.System.System.debug("Class Setup Called");
        }

        [Test]
        public static void assert()
        {
            Apex.System.System.assert(true, "Assert True");
        }
    }
}
