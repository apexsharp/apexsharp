namespace Apex.ChatterAnswers
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SCCForgotPasswordController
    {
        // infrastructure
        public SCCForgotPasswordController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SCCForgotPasswordController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
