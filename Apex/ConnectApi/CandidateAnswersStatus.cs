namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class CandidateAnswersStatus
    {
        // infrastructure
        public CandidateAnswersStatus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CandidateAnswersStatus));
            }
        }

        // API
        object hasCandidateAnswers
        {
            get
            {
                return Self.hasCandidateAnswers;
            }
            set
            {
                Self.hasCandidateAnswers = value;
            }
        }

        object hasCandidateAnswersPublished
        {
            get
            {
                return Self.hasCandidateAnswersPublished;
            }
            set
            {
                Self.hasCandidateAnswersPublished = value;
            }
        }

        object hasCandidateAnswersRated
        {
            get
            {
                return Self.hasCandidateAnswersRated;
            }
            set
            {
                Self.hasCandidateAnswersRated = value;
            }
        }

        public CandidateAnswersStatus()
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
