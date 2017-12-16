using Serilog;

namespace AdvanceDemo
{
    public class Logging
    {
        public static void EnableLogging()
        {
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            // Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognized problems
            // Information - events of interest or that have relevance to outside observers; the default enabled minimum logging level
            // Warning - indicators of possible issues or service/functionality degradation
            // Error - indicating a failure within the application or connected system
            // Fatal - critical errors causing complete failure of the application
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] [{SourceContext}] {Message} {NewLine}")
                .MinimumLevel.Debug()
                // If you are using https://getseq.net
                //.WriteTo.Seq("http://localhost:9999")
                .CreateLogger();

            Log.ForContext<Setup>().Debug("One Time Setup Got Called");
        }

        public static void CloseLogging()
        {
            Log.CloseAndFlush();
        }
    }
}
