namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TemplateInterruptException
    {
        // infrastructure
        public TemplateInterruptException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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
            Implementation.Constructor();
        }

        public TemplateInterruptException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public TemplateInterruptException(string msg)
        {
            Implementation.Constructor(msg);
        }

        public TemplateInterruptException(string param1, Exception param2)
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
