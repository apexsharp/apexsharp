using Demo;
using NUnit.Framework;

namespace AdvanceDemo
{
    [SetUpFixture]
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public static void Init()
        {
            // Start Logging
            Logging.EnableLogging();
            // Always Initialize your settings before using it.
            Setup.Init();

            //UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            //UnitTestDataManager.UnitTestDataManagerOff();

            // Flush and Close
            Logging.CloseLogging();
        }
    }
}
