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
    public class DmlException
    {
        // infrastructure
        public DmlException(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DmlException));
            }
        }

        // API
        public DmlException()
        {
            Implementation.Constructor();
        }

        public DmlException(Exception param1)
        {
            Implementation.Constructor(param1);
        }

        public DmlException(string param1)
        {
            Implementation.Constructor(param1);
        }

        public DmlException(string param1, Exception param2)
        {
            Implementation.Constructor(param1, param2);
        }

        public Exception getCause()
        {
            return Self.getCause();
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

        public int getLineNumber()
        {
            return Self.getLineNumber();
        }

        public string getMessage()
        {
            return Self.getMessage();
        }

        public int getNumDml()
        {
            return Self.getNumDml();
        }

        public string getStackTraceString()
        {
            return Self.getStackTraceString();
        }

        public string getTypeName()
        {
            return Self.getTypeName();
        }

        public void initCause(Exception cause)
        {
            Self.initCause(cause);
        }

        public void setMessage(string message)
        {
            Self.setMessage(message);
        }
    }
}
