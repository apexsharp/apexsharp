namespace Apex.Process
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InputParameter
    {
        // infrastructure
        public InputParameter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InputParameter));
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

        public InputParameter(string name, ParameterType parameterType, bool required)
        {
            Self = Implementation.Constructor(name, parameterType, required);
        }

        public InputParameter(string name, string description, ParameterType parameterType, bool required)
        {
            Self = Implementation.Constructor(name, description, parameterType, required);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
