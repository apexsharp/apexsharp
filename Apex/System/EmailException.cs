namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EmailException : Exception
    {
        // infrastructure
        public EmailException(dynamic self)
        {
            Self = self;
        }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EmailException));
            }
        }

        // API
        public EmailException()
        {
            Self = Implementation.Constructor();
        }

        public EmailException(Exception param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmailException(string param1)
        {
            Self = Implementation.Constructor(param1);
        }

        public EmailException(string param1, Exception param2)
        {
            Self = Implementation.Constructor(param1, param2);
        }

        public List<string> getDmlFieldNames(int index)
        {
            return Self.getDmlFieldNames(index);
        }

        public List<SObjectField> getDmlFields(int index)
        {
            return Self.getDmlFields(index);
        }

        public string getDmlId(int index)
        {
            return Self.getDmlId(index);
        }

        public int getDmlIndex(int index)
        {
            return Self.getDmlIndex(index);
        }

        public string getDmlMessage(int index)
        {
            return Self.getDmlMessage(index);
        }

        public string getDmlStatusCode(int index)
        {
            return Self.getDmlStatusCode(index);
        }

        public StatusCode getDmlType(int index)
        {
            return Self.getDmlType(index);
        }

        public int getNumDml()
        {
            return Self.getNumDml();
        }
    }
}
