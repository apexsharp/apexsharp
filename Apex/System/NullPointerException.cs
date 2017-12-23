namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class NullPointerException : Exception
    {
        // infrastructure
        public NullPointerException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(NullPointerException));
            }
        }

        // API
        public NullPointerException()
        {
            Self = Implementation.Constructor();
        }
    }
}
