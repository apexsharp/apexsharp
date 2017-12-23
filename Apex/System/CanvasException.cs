namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CanvasException : Exception
    {
        // infrastructure
        public CanvasException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CanvasException));
            }
        }

        // API
        public CanvasException()
        {
            Self = Implementation.Constructor();
        }

        public CanvasException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CanvasException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CanvasException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
