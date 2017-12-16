namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QuestionAttachment
    {
        // infrastructure
        public QuestionAttachment(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuestionAttachment));
            }
        }

        // API
        object bestAnswer
        {
            get
            {
                return Self.bestAnswer;
            }
            set
            {
                Self.bestAnswer = value;
            }
        }

        object bestAnswerSelectedBy
        {
            get
            {
                return Self.bestAnswerSelectedBy;
            }
            set
            {
                Self.bestAnswerSelectedBy = value;
            }
        }

        object canCurrentUserSelectOrRemoveBestAnswer
        {
            get
            {
                return Self.canCurrentUserSelectOrRemoveBestAnswer;
            }
            set
            {
                Self.canCurrentUserSelectOrRemoveBestAnswer = value;
            }
        }

        object questionTitle
        {
            get
            {
                return Self.questionTitle;
            }
            set
            {
                Self.questionTitle = value;
            }
        }

        public QuestionAttachment()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
