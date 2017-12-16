namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class WaveTemplateInfo
    {
        // infrastructure
        public WaveTemplateInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WaveTemplateInfo));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getApiName()
        {
            return Self.getApiName();
        }

        public ReleaseInfo getReleaseInfo()
        {
            return Self.getReleaseInfo();
        }

        public UI getUI()
        {
            return Self.getUI();
        }

        public Map<string, VariableDefinition> getVariables()
        {
            return Self.getVariables();
        }
    }
}
