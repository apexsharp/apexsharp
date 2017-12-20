namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class WaveQueryException : Exception
    {
        // infrastructure
        public WaveQueryException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(WaveQueryException));
            }
        }

        // API
        public WaveQueryException()
        {
            Self = Implementation.Constructor();
        }

        public WaveQueryException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public WaveQueryException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}
