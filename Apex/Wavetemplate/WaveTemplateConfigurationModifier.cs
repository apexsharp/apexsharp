namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class WaveTemplateConfigurationModifier
    {
        // infrastructure
        public WaveTemplateConfigurationModifier(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WaveTemplateConfigurationModifier));
            }
        }

        // API
        public WaveTemplateConfigurationModifier()
        {
            Implementation.Constructor();
        }

        public void beforeAppCreate(WaveTemplateInfo template, Answers answers)
        {
            Self.beforeAppCreate(template, answers);
        }

        public void beforeAppUpdate(WaveTemplateInfo template, string previousAppVersion, Answers answers)
        {
            Self.beforeAppUpdate(template, previousAppVersion, answers);
        }

        public object clone()
        {
            return Self.clone();
        }

        public void onConfigurationRetrieval(WaveTemplateInfo template)
        {
            Self.onConfigurationRetrieval(template);
        }
    }
}
