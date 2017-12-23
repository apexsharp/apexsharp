namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartResponses
    {
        // infrastructure
        public SmartResponses(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartResponses));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public static SmartAnswers getSmartAnswers(string communityId, string questionId, string questionText, int maxResults)
        {
            return Implementation.getSmartAnswers(communityId, questionId, questionText, maxResults);
        }
    }
}
