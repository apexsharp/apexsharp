namespace Apex.Databinding
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectMappingException : Exception
    {
        // infrastructure
        public ObjectMappingException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ObjectMappingException));
            }
        }

        // API
        public ObjectMappingException()
        {
            Self = Implementation.Constructor();
        }

        public ObjectMappingException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ObjectMappingException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public ObjectMappingException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }
    }
}