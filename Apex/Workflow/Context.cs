namespace Apex.Workflow
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Context
    {
        // infrastructure
        public Context(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Context));
            }
        }

        // API
        object sobjects
        {
            get
            {
                return Self.sobjects;
            }
            set
            {
                Self.sobjects = value;
            }
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
