namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BatchResult
    {
        // infrastructure
        public BatchResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BatchResult));
            }
        }

        // API
        Exception error
        {
            get
            {
                return Self.error;
            }
            set
            {
                Self.error = value;
            }
        }

        string errorMessage
        {
            get
            {
                return Self.errorMessage;
            }
            set
            {
                Self.errorMessage = value;
            }
        }

        string errorTypeName
        {
            get
            {
                return Self.errorTypeName;
            }
            set
            {
                Self.errorTypeName = value;
            }
        }

        object IsSuccess
        {
            get
            {
                return Self.IsSuccess;
            }
            set
            {
                Self.IsSuccess = value;
            }
        }

        object result
        {
            get
            {
                return Self.result;
            }
            set
            {
                Self.result = value;
            }
        }

        public BatchResult(object result, Exception error)
        {
            Implementation.Constructor(result, error);
        }

        public object clone()
        {
            return Self.clone();
        }

        public Exception getError()
        {
            return Self.getError();
        }

        public string getErrorMessage()
        {
            return Self.getErrorMessage();
        }

        public string getErrorTypeName()
        {
            return Self.getErrorTypeName();
        }

        public object getResult()
        {
            return Self.getResult();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
