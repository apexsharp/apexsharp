using Microsoft.Extensions.Configuration;
using Serilog;

namespace Demo
{
    using System;
    using System.IO;
    using ApexSharpApi;

    public class Setup
    {
        public static void StartLogging()
        {
            var logPath = Path.GetFullPath(@"../log.log");
            StartLogging(logPath);
        }

        public static void StartLogging(string logPath)
        {    
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            // Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognized problems
            // Information - events of interest or that have relevance to outside observers; the default enabled minimum logging level
            // Warning - indicators of possible issues or service/functionality degradation
            // Error - indicating a failure within the application or connected system
            // Fatal - critical errors causing complete failure of the application
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] [{SourceContext}] {Message} {NewLine}")
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Day, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] [{SourceContext}] {Message} {NewLine}")
                .MinimumLevel.Debug()
                .CreateLogger();

            Log.ForContext<Setup>().Debug("Logging Started");

        }

        public static void StopLogging()
        {
            Log.ForContext<Setup>().Debug("Logging Stopped");
            Log.CloseAndFlush();
        }

        public static bool InitializeSession()
        {
            // SessionLocation is where your SF session will be saved or located
            var sessionFileInfo = new FileInfo(Path.GetFullPath(@"../config.json"));
            // SalesForceLocation is the location of your Salesofrce project
            var salesForceLocation = Path.GetFullPath(@"../SalesForce/src/");
            // VsProjectLocation is the location of your Visual Studio Project
            var vSprojectocation = Path.GetFullPath(@"../Demo/");

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
            return true;
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
                    .SetBasePath(Directory.GetCurrentDirectory())
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
