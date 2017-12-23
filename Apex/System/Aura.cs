namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Aura
    {
        // infrastructure
        public Aura(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Aura));
            }
        }

        // API
        public static void redirect(PageReference pageReference)
        {
            Implementation.redirect(pageReference);
        }
    }
}
