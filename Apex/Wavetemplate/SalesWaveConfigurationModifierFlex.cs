namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SalesWaveConfigurationModifierFlex
    {
        // infrastructure
        public SalesWaveConfigurationModifierFlex(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SalesWaveConfigurationModifierFlex));
            }
        }

        // API
        public SalesWaveConfigurationModifierFlex()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
