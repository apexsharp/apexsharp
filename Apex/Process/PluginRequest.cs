namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Process_PluginRequest.htm#apex_class_Process_PluginRequest
    /// </summary>
    public class PluginRequest
    {
        // infrastructure
        public PluginRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PluginRequest));
            }
        }

        // API
        Map<string, object> inputParameters
        {
            get
            {
                return Self.inputParameters;
            }
            set
            {
                Self.inputParameters = value;
            }
        }

        public PluginRequest(Map<string, object> inputParameters)
        {
            Self = Implementation.Constructor(inputParameters);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
