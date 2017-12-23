namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ReleaseInfo
    {
        // infrastructure
        public ReleaseInfo(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ReleaseInfo));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public string getTemplateVersion()
        {
            return Self.getTemplateVersion();
        }
    }
}
