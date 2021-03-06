namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TemplateInterruptException : Exception
    {
        // infrastructure
        public TemplateInterruptException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TemplateInterruptException));
            }
        }

        // API
        public TemplateInterruptException()
        {
            Self = Implementation.Constructor();
        }

        public TemplateInterruptException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public TemplateInterruptException(string msg)
        {
            Self = Implementation.Constructor(msg);
        }

        public TemplateInterruptException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
