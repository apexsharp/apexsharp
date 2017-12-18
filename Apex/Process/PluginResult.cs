namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Process_PluginResult.htm#apex_class_Process_PluginResult
    /// </summary>
    public class PluginResult
    {
        // infrastructure
        public PluginResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PluginResult));
            }
        }

        // API
        Map<string, object> outputParameters
        {
            get
            {
                return Self.outputParameters;
            }
            set
            {
                Self.outputParameters = value;
            }
        }

        public PluginResult(Map<string, object> outputParameters)
        {
            Self = Implementation.Constructor(outputParameters);
        }

        public PluginResult(string outputKey, object outputValue)
        {
            Self = Implementation.Constructor(outputKey, outputValue);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
