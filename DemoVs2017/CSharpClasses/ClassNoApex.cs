namespace DemoVs2017.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class ClassNoApex
    {
        // Any classes in NoApex name space will be commented out in Apex and uncommented on c#.
        public static void methodOne()
        {
            NoApex.Serilog.LogInfo("Jay");
        }

        // Any method in NoApex name space will be commented out in Apex and uncommented on c#.
        public static void noApexMethodTwo()
        {
            {
                {
                    {
                        {
                            {
                                NoApex.Serilog.LogInfo("Jay");
                            }

                            NoApex.Serilog.LogInfo("Jay");
                        }

                        NoApex.Serilog.LogInfo("Jay");
                    }

                    NoApex.Serilog.LogInfo("Jay");
                }

                NoApex.Serilog.LogInfo("Jay");
            }

            NoApex.Serilog.LogInfo("Jay");
        }
    }
}
