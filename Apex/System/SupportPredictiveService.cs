namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SupportPredictiveService
    {
        // infrastructure
        public SupportPredictiveService(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SupportPredictiveService));
            }
        }

        // API
        public SupportPredictiveService()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<ID> findSimilarCases(string caseId)
        {
            return Implementation.findSimilarCases(caseId);
        }
    }
}
