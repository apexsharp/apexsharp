namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TouchHandledException : Exception
    {
        // infrastructure
        public TouchHandledException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TouchHandledException));
            }
        }

        // API
        public TouchHandledException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }
    }
}
