namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class HandledException : Exception
    {
        // infrastructure
        public HandledException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(HandledException));
            }
        }

        // API
        public HandledException()
        {
            Self = Implementation.Constructor();
        }

        public HandledException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public HandledException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public HandledException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
