namespace Apex.ChatterAnswers
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SCCForgotPasswordConfirmController
    {
        // infrastructure
        public SCCForgotPasswordConfirmController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SCCForgotPasswordConfirmController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}
