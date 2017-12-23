namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class ProcedureException : Exception
    {
        // infrastructure
        public ProcedureException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ProcedureException));
            }
        }

        // API
        public ProcedureException()
        {
            Self = Implementation.Constructor();
        }

        public ProcedureException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ProcedureException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ProcedureException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
