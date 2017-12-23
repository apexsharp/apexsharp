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

                var sessionFileInfo = new FileInfo(Path.GetFullPath(configuration["SessionFileInfo"]));

                // You can del the existing session if needed (Ex: you changed the Password), if you delete every time a new session is created which will delay the code. 
                File.Delete(sessionFileInfo.FullName);

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
