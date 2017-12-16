namespace Apex.Flow
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/flow_interview_class.htm#flow_interview_class
    /// </summary>
    public class Interview
    {
        // infrastructure
        public Interview(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Interview));
            }
        }

        // API
        public object getVariableValue(string variableName)
        {
            return Self.getVariableValue(variableName);
        }

        public void start()
        {
            Self.start();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
