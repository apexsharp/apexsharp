namespace Apex.ChatterAnswers
{
    using ApexSharp.Implementation;
    using System;

    public class ChatterServiceRegisterController
    {
        // infrastructure
        public ChatterServiceRegisterController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterServiceRegisterController));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }
    }
}