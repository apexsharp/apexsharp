namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InstanceAccessException : Exception
    {
        // infrastructure
        public InstanceAccessException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InstanceAccessException));
            }
        }

        // API
        public InstanceAccessException()
        {
            Self = Implementation.Constructor();
        }

        public InstanceAccessException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public InstanceAccessException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
