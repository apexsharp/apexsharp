namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum FeedFilter
    {
        AllQuestions,
        AuthoredBy,
        CommunityScoped,
        QuestionsWithCandidateAnswers,
        QuestionsWithCandidateAnswersReviewedPublished,
        Read,
        SolvedQuestions,
        UnansweredQuestions,
        UnansweredQuestionsWithCandidateAnswers,
        Unread,
        UnsolvedQuestions
    }
}
