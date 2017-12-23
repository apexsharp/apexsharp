using System.IO;
using ApexSharpApi;
using Microsoft.Extensions.Configuration;
using Serilog;

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
            Setup.StartLogging(@"log.log");

            // SessionFileInfo is where your SF session will be saved or located
            var sessionFileInfo = new FileInfo(Path.GetFullPath(@"c:/apexSharp/config.json"));
            // SalesForceLocation is the location of your Salesofrce project
            var salesForceLocation = Path.GetFullPath(@"c:/apexSharp/SalesForce/src/");
            // VsProjectLocation is the location of your Visual Studio Project
            var vSprojectocation = Path.GetFullPath(@"c:/apexSharp/Demo/");

            // You can del the existing session if needed.
            // File.Delete(sessionFileInfo.FullName);

            if (sessionFileInfo.Exists)
            {
                ConnectionUtil.Session = ConnectionUtil.GetSession(sessionFileInfo.FullName);
            }
            // Else Create a new session
            else
            {
                CreateSession(sessionFileInfo.FullName, salesForceLocation, vSprojectocation);
            }

            UnitTestDataManager.UnitTestDataManagerOn();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            UnitTestDataManager.UnitTestDataManagerOff();

            // Flush and Close
            Setup.StopLogging();
        }

        private static void CreateSession(string sessionLocation, string salesForceLocation, string vSprojectocation)
        {
            try
            {
                // You need to have a JSON File names appsettings.json with your SF credential in your project. For example
                // {
                //    "SalesForceUserId": "Your SF Id",
                //    "SalesForcePassword": "SF Password",
                //    "SalesForcePasswordToken": "SF Token"
                // }

                var builder = new ConfigurationBuilder()
                    .SetBasePath(Path.GetDirectoryName(typeof(Program).Assembly.Location))
                    .AddJsonFile("appsettings.json");



                var configuration = builder.Build();

                new ApexSharp()
                    .SalesForceUrl("https://login.salesforce.com/")
                    .AndSalesForceApiVersion(40)
                    .WithUserId(configuration["SalesForceUserId"])
                    .AndPassword(configuration["SalesForcePassword"])
                    .AndToken(configuration["SalesForcePasswordToken"])
                    .SalesForceLocation(salesForceLocation)
                    .VsProjectLocation(vSprojectocation)
                    .SaveConfigAt(sessionLocation)
                    .CreateSession();

                ConnectionUtil.Session = ConnectionUtil.GetSession(sessionLocation);
            }
            catch (FileNotFoundException ex)
            {
                Log.ForContext<Setup>().Debug(ex.Message);
            }
            catch (SalesForceInvalidLoginException ex)
            {
                Log.ForContext<Setup>().Debug(ex.Message);
            }
        }
    }
}
