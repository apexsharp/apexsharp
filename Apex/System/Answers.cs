namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_answers.htm#apex_classes_answers
    /// </summary>
    public class Answers
    {
        // infrastructure
        public Answers(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Answers));
            }
        }

        // API
        public static ID[] findSimilar(Question yourQuestion)
        {
            return Implementation.findSimilar(yourQuestion);
        }

        public static void setBestReply(string questionId, string replyId)
        {
            Implementation.setBestReply(questionId, replyId);
        }

        public Answers()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static List<ID> findSimilar(SObject question)
        {
            return Implementation.findSimilar(question);
        }
    }
}
