namespace Demo
{
    using ApexSharpApi;
    using NUnit.Framework;

    // This class gets called once every time any Unit Test runs. 
    [SetUpFixture]
    public class OneTimeSetUp
    {
        [OneTimeSetUp]
        public static void Init()
        {
            Setup.InitializeSession();
            UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            UnitTestDataManager.UnitTestDataManagerOff();

            // Flush and Close
            Setup.StopLogging();
        }
    }
}
