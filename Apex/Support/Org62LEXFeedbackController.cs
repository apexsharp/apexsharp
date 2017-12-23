namespace Apex.Support
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Org62LEXFeedbackController
    {
        // infrastructure
        public Org62LEXFeedbackController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Org62LEXFeedbackController));
            }
        }

        // API
        object comment
        {
            get
            {
                return Self.comment;
            }
            set
            {
                Self.comment = value;
            }
        }

        public Org62LEXFeedbackController()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public PageReference init()
        {
            return Self.init();
        }

        public PageReference postFeedback()
        {
            return Self.postFeedback();
        }
    }
}
