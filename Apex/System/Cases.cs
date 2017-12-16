namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Cases
    {
        // infrastructure
        public Cases(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Cases));
            }
        }

        // API
        public Cases()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ID getCaseIdFromEmailThreadId(string emailThreadId)
        {
            return Implementation.getCaseIdFromEmailThreadId(emailThreadId);
        }
    }
}
