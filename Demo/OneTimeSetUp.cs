namespace Demo
{
    using NUnit.Framework;

    // This class gets called once every time any Unit Test runs. 
    [SetUpFixture]
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public static void Init()
        {
            // Start Logging
            Logging.StartLogging();
            // Always Initialize your settings before using it.
            Setup.Init();

            //UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            //UnitTestDataManager.UnitTestDataManagerOff();

            // Flush and Close
            Logging.StopLogging();
        }
    }
}
