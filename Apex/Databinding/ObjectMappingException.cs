namespace Apex.Databinding
{
    using ApexSharp.Implementation;
    using System;

    public class ObjectMappingException
    {
        // infrastructure
        public ObjectMappingException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

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