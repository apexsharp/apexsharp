namespace Demo
{
    using System;
    using System.IO;
    using ApexSharpApi;
    using Serilog;

    public class Setup
    {
        public static bool Init()
        {
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            // Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognized problems
            // Information - events of interest or that have relevance to outside observers; the default enabled minimum logging level
            // Warning - indicators of possible issues or service/functionality degradation
            // Error - indicating a failure within the application or connected system
            // Fatal - critical errors causing complete failure of the application
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] [{SourceContext}] {Message} {NewLine}")
                .MinimumLevel.Verbose()
                // If you are using https://getseq.net
                .WriteTo.Seq("http://localhost:9999")
                .CreateLogger();

            Log.ForContext<Setup>().Debug("One Time Setup Got Called");
            
            File.Delete(@"\ApexSharp\config.json");

            try
            {
                // See if we have an existing connection
                ConnectionUtil.Session = ConnectionUtil.GetSession(@"\ApexSharp\config.json");
            }
            // Else Create a new session
            catch (SalesForceNoFileFoundException)
            {
                try
                {
                    // This example assumes you cloned your GIT repo to the root level.
                    ConnectionUtil.Session = new ApexSharp().
                         SalesForceUrl("https://login.salesforce.com/")
                        .AndSalesForceApiVersion(40)
                        .WithUserId("User ID")
                        .AndPassword("Password")
                        .AndToken("Token")
                        .SalesForceLocation(@"\ApexSharp\SalesForce\src\")
                        .VsProjectLocation(@"\ApexSharp\Demo\")
                        .SaveConfigAt(@"\ApexSharp\config.json")
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
