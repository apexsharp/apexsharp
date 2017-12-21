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
            var logPath = Path.GetFullPath(@"/apexsharp/log.log");

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

        public static bool Init()
        { 
            // Due to different OS and how they manage file paths, its best to to use the Path.GetFullPath Method.
            // This example assumes you cloned your GIT repo to the root level.

            // SessionLocation is where your SF session will be Saved
            var sessionLocation = Path.GetFullPath(@"../config.json");
            // SalesForceLocation is the location of your Salesofrce project
            var salesForceLocation = Path.GetFullPath(@"../SalesForce/src/");
            // VsProjectLocation is the location of your Visual Studio Project
            var vSprojectocation = Path.GetFullPath(@"../Demo/");

            try
            {
                // See if we have an existing connection use it.
                ConnectionUtil.Session = ConnectionUtil.GetSession(sessionLocation);
            }
            // Else Create a new session
            catch (SalesForceNoFileFoundException)
            {
                try
                {                    
                    ConnectionUtil.Session = new ApexSharp().
                         SalesForceUrl("https://test.salesforce.com/")
                        .AndSalesForceApiVersion(40)
                        
                        .WithUserId("allison@healthclx.com.test")
                        .AndPassword("healthclxer007")
                        .AndToken("")

                        .SalesForceLocation(salesForceLocation)
                        .VsProjectLocation(vSprojectocation)
                        .SaveConfigAt(sessionLocation)
                        .CreateSession();
                }
                catch (SalesForceInvalidLoginException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
