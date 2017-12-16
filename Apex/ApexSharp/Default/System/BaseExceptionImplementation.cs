using Apex.ApexSharp.Implementation;
using Apex.System;
using Activator = System.Activator;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(Exception))]
    public class ExceptionImplementation : BaseExceptionImplementation<Exception>
    {
    }

    public class BaseExceptionImplementation<T> where T : Exception, new()
    {
        // Self

        public class ExceptionInstance
        {
            public Exception Cause { get; set; }

            public Exception getCause() => Cause;

            public void initCause(Exception cause) => Cause = cause;

            public int LineNumber { get; set; }

            public int getLineNumber() => LineNumber;

            public string Message { get; set; }

            public string getMessage() => Message;

            public void setMessage(string message) => Message = message;

            public string StackTrace { get; set; }

            public string getStackTraceString() => StackTrace;

            public string TypeName => typeof(T).Name;

            public string getTypeName() => TypeName;

            public object clone() => Activator.CreateInstance(typeof(T), this);
        }

        // Implementation

        public BaseExceptionImplementation(string defaultMessage = null)
        {
            DefaultMessage = defaultMessage ?? "Exception occured.";
        }

        private string DefaultMessage { get; set; }

        public dynamic Constructor()
        {
            return new ExceptionInstance { Message = DefaultMessage };
        }

        public dynamic Constructor(string message)
        {
            return new ExceptionInstance { Message = message };
        }

        public dynamic Constructor(Exception cause)
        {
            return new ExceptionInstance { Message = DefaultMessage, Cause = cause };
        }

        public dynamic Constructor(string message, Exception cause)
        {
            return new ExceptionInstance { Message = message, Cause = cause };
        }
    }
}
