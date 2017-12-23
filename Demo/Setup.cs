using Microsoft.Extensions.Configuration;
using Serilog;

namespace Demo
{
    using System;
    using System.IO;
    using ApexSharpApi;

    public class Setup
    {
        public static void InitializeSession()
        {
            // You need to have a JSON File name appsettings.json with your SF credential in your project.
            // See https://github.com/apexsharp/apexsharp/blob/master/README.md
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(typeof(Program).Assembly.Location))
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            var logFile = new FileInfo(Path.GetFullPath(configuration["LogFile"]));
            if (logFile.Directory.Exists)
            {
                // Make sure you enable logging. We use Serilog loggign library. 
                // See https://github.com/serilog/serilog/wiki/Configuration-Basics
                Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console(outputTemplate:"{Timestamp:yyyy-MM-dd HH-mm-ss.fff}:[{Level}]:[{SourceContext}]:{Message}:{NewLine}")
                    .WriteTo.File(logFile.FullName, rollingInterval: RollingInterval.Day,outputTemplate:"{Timestamp:yyyy-MM-dd HH-mm-ss.fff}:[{Level}]:[{SourceContext}]:{Message}:{NewLine}")
                    .MinimumLevel.Debug()
                    .CreateLogger();

                Log.ForContext<Setup>().Debug("Logging Started");

<<<<<<< HEAD
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
                         SalesForceUrl("https://test.salesforce.com/")  // your org....prod/dev is login.salesforce.com and sandbox is test.salesforce.com
                        .AndSalesForceApiVersion(40)
                        
                        .WithUserId("YOUR USER ID")
                        .AndPassword("YOUR PASSWORD")
                        .AndToken("YOUR TOKEN")
=======
                var sessionFileInfo = new FileInfo(Path.GetFullPath(configuration["SessionFileInfo"]));

                // You can del the existing session if needed (Ex: you changed the Password), if you delete every time a new session is created which will delay the code. 
                File.Delete(sessionFileInfo.FullName);
>>>>>>> dev

                if (sessionFileInfo.Exists)
                {
                    ConnectionUtil.Session = ConnectionUtil.GetSession(sessionFileInfo.FullName);
                }
                // Else Create a new session
                else
                {
                    try
                    {
                        var salesForceLocation = Path.GetFullPath(configuration["SalesForceLocation"]);
                        var vSprojectocation = Path.GetFullPath(configuration["VsProjectocation"]);

                        new ApexSharp()
                            .SalesForceUrl("https://login.salesforce.com/")
                            .AndSalesForceApiVersion(40)
                            .WithUserId(configuration["SalesForceUserId"])
                            .AndPassword(configuration["SalesForcePassword"])
                            .AndToken(configuration["SalesForceToken"])
                            .SalesForceLocation(salesForceLocation)
                            .VsProjectLocation(vSprojectocation)
                            .SaveConfigAt(sessionFileInfo.FullName)
                            .CreateSession();

                        ConnectionUtil.Session = ConnectionUtil.GetSession(sessionFileInfo.FullName);
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
            } else {
                Console.WriteLine("Cant Find the path to the log location");
            }

        }

        public static void StopLogging()
        {
            Log.ForContext<Setup>().Debug("Logging Stopped");
            Log.CloseAndFlush();
        }
    }
}
