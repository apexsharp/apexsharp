namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RelatedQuestion
    {
        // infrastructure
        public RelatedQuestion(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RelatedQuestion));
            }
        }

        // API
        object hasBestAnswer
        {
            get
            {
                return Self.hasBestAnswer;
            }
            set
            {
                Self.hasBestAnswer = value;
            }
        }

        object interactions
        {
            get
            {
                return Self.interactions;
            }
            set
            {
                Self.interactions = value;
            }
        }

        public RelatedQuestion()
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
