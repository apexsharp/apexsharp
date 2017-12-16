namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Test
    {
        // infrastructure
        public Test(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Test));
            }
        }

        // API
        public Test()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Answers getDefaultAnswersForApexTesting(string templateDevName)
        {
            return Implementation.getDefaultAnswersForApexTesting(templateDevName);
        }

        public static WaveTemplateInfo getWaveTemplateInfoForApexTesting(string templateDevName)
        {
            return Implementation.getWaveTemplateInfoForApexTesting(templateDevName);
        }
    }
}
