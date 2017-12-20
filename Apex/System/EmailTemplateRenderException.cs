namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailTemplateRenderException : Exception
    {
        // infrastructure
        public EmailTemplateRenderException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailTemplateRenderException));
            }
        }

        // API
        public EmailTemplateRenderException()
        {
            Self = Implementation.Constructor();
        }

        public EmailTemplateRenderException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmailTemplateRenderException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmailTemplateRenderException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
