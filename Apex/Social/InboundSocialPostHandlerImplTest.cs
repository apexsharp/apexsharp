namespace Apex.Social
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InboundSocialPostHandlerImplTest
    {
        // infrastructure
        public InboundSocialPostHandlerImplTest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InboundSocialPostHandlerImplTest));
            }
        }

        // API
        public InboundSocialPostHandlerImplTest()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
