using Apex.ApexSharp.NUnit;

namespace DemoVs2017
{
    [TestFixture]
    public class ClassUnitTest
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
