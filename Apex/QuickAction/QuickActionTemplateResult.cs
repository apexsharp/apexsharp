namespace Apex.QuickAction
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QuickActionTemplateResult
    {
        // infrastructure
        public QuickActionTemplateResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuickActionTemplateResult));
            }
        }

        // API
        SObject defaultValueFormulas
        {
            get
            {
                return Self.defaultValueFormulas;
            }
            set
            {
                Self.defaultValueFormulas = value;
            }
        }

        SObject defaultValues
        {
            get
            {
                return Self.defaultValues;
            }
            set
            {
                Self.defaultValues = value;
            }
        }

        List<Error> errors
        {
            get
            {
                return Self.errors;
            }
            set
            {
                Self.errors = value;
            }
        }

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }

        public SObject getDefaultValueFormulas()
        {
            return Self.getDefaultValueFormulas();
        }

        public SObject getDefaultValues()
        {
            return Self.getDefaultValues();
        }

        public List<Error> getErrors()
        {
            return Self.getErrors();
        }

        public bool isSuccess()
        {
            return Self.isSuccess();
        }
    }
}
