namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SchedulableContextImpl
    {
        // infrastructure
        public SchedulableContextImpl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SchedulableContextImpl));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
