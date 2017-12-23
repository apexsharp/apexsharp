namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QuestionAndAnswersCapabilityInput
    {
        // infrastructure
        public QuestionAndAnswersCapabilityInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QuestionAndAnswersCapabilityInput));
            }
        }

        // API
        object bestAnswerId
        {
            get
            {
                return Self.bestAnswerId;
            }
            set
            {
                Self.bestAnswerId = value;
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

        public QuestionAndAnswersCapabilityInput()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
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
