namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class WaveTemplateException : Exception
    {
        // infrastructure
        public WaveTemplateException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WaveTemplateException));
            }
        }

        // API
        public WaveTemplateException()
        {
            Self = Implementation.Constructor();
        }

        public WaveTemplateException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public WaveTemplateException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public WaveTemplateException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
