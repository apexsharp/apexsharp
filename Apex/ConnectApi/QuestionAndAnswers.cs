namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_QuestionAndAnswers_static_methods.htm#apex_ConnectAPI_QuestionAndAnswers_static_methods
    /// </summary>
    public class QuestionAndAnswers
    {
        // infrastructure
        public QuestionAndAnswers(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuestionAndAnswers));
            }
        }

        // API
        public static QuestionAndAnswersSuggestions getSuggestions(string communityId, string q, string subjectId, bool includeArticles, int maxResults)
        {
            return Implementation.getSuggestions(communityId, q, subjectId, includeArticles, maxResults);
        }

        public static void setTestGetSuggestions(string communityId, string q, string subjectId, bool includeArticles, int maxResults, QuestionAndAnswersSuggestions result)
        {
            Implementation.setTestGetSuggestions(communityId, q, subjectId, includeArticles, maxResults, result);
        }

        public static QuestionAndAnswersCapability updateQuestionAndAnswers(string communityId, string feedElementId, QuestionAndAnswersCapabilityInput questionAndAnswersCapability)
        {
            return Implementation.updateQuestionAndAnswers(communityId, feedElementId, questionAndAnswersCapability);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
