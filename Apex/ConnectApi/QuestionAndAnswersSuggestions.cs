namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QuestionAndAnswersSuggestions
    {
        // infrastructure
        public QuestionAndAnswersSuggestions(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuestionAndAnswersSuggestions));
            }
        }

        // API
        object articles
        {
            get
            {
                return Self.articles;
            }
            set
            {
                Self.articles = value;
            }
        }

        object questions
        {
            get
            {
                return Self.questions;
            }
            set
            {
                Self.questions = value;
            }
        }

        public QuestionAndAnswersSuggestions()
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
