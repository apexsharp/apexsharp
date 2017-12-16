namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SparkPlugApi
    {
        // infrastructure
        public SparkPlugApi(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SparkPlugApi));
            }
        }

        // API
        public SparkPlugApi()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static SparkPlugDescribeResult describePlugin(string className)
        {
            return Implementation.describePlugin(className);
        }

        public static List<SparkPlugDescribeResult> describePlugins()
        {
            return Implementation.describePlugins();
        }

        public static string invokePluginWithJson(string className, string parameters)
        {
            return Implementation.invokePluginWithJson(className, parameters);
        }
    }
}
