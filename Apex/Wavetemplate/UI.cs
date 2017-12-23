namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class UI
    {
        // infrastructure
        public UI(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UI));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public List<UIPage> getPages()
        {
            return Self.getPages();
        }
    }
}
