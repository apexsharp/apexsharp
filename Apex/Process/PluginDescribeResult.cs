namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Process_PluginDescribeResult.htm#apex_class_Process_PluginDescribeResult
    /// </summary>
    public class PluginDescribeResult
    {
        // infrastructure
        public PluginDescribeResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PluginDescribeResult));
            }
        }

        // API
        public PluginDescribeResult()
        {
            Self = Implementation.Constructor();
        }

        string description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        List<InputParameter> inputParameters
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

        string name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        List<OutputParameter> outputParameters
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

        string tag
        {
            get
            {
                return Self.tag;
            }
            set
            {
                Self.tag = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
