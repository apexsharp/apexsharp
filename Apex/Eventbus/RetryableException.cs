namespace Apex.EventBus
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RetryableException
    {
        // infrastructure
        public RetryableException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RetryableException));
            }
        }

        // API
        public RetryableException()
        {
            Implementation.Constructor();
        }

        public RetryableException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public RetryableException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public RetryableException(string param1, Exception param2)
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
