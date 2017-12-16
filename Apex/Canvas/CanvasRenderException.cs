namespace Apex.Canvas
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CanvasRenderException
    {
        // infrastructure
        public CanvasRenderException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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
            Implementation.Constructor();
        }

        public CanvasRenderException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public CanvasRenderException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public CanvasRenderException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }
    }
}
