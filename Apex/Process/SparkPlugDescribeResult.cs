namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SparkPlugDescribeResult
    {
        // infrastructure
        public SparkPlugDescribeResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SparkPlugDescribeResult));
            }
        }

        // API
        object inputParameters
        {
            get
            {
                return Self.inputParameters;
            }
            set
            {
                Self.inputParameters = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object outputParameters
        {
            get
            {
                return Self.outputParameters;
            }
            set
            {
                Self.outputParameters = value;
            }
        }

        public SparkPlugDescribeResult()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
