namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class OutputParameter
    {
        // infrastructure
        public OutputParameter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(OutputParameter));
            }
        }

        // API
        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
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

        public OutputParameter(string name, ParameterType parameterType)
        {
            Implementation.Constructor(name, parameterType);
        }

        public OutputParameter(string name, string description, ParameterType parameterType)
        {
            Implementation.Constructor(name, description, parameterType);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
