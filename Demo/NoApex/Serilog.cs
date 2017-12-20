using Serilog;

namespace Demo.NoApex
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Serilog
    {
        public static void LogInfo(string log) 
        {
            Log.ForContext<Serilog>().Debug(log);
        }
    }
}
