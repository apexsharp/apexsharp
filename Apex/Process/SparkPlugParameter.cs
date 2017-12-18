namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SparkPlugParameter
    {
        // infrastructure
        public SparkPlugParameter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SparkPlugParameter));
            }
        }

        // API
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

        object parameterType
        {
            get
            {
                return Self.parameterType;
            }
            set
            {
                Self.parameterType = value;
            }
        }

        object required
        {
            get
            {
                return Self.required;
            }
            set
            {
                Self.required = value;
            }
        }

        public SparkPlugParameter()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
