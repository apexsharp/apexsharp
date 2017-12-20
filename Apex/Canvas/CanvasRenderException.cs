namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CanvasRenderException : Exception
    {
        // infrastructure
        public CanvasRenderException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CanvasRenderException));
            }
        }

        // API
        public CanvasRenderException()
        {
            Self = Implementation.Constructor();
        }

        public CanvasRenderException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CanvasRenderException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public CanvasRenderException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
