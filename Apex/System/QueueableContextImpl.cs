namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class QueueableContextImpl
    {
        // infrastructure
        public QueueableContextImpl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueueableContextImpl));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ID getJobId()
        {
            return Self.getJobId();
        }
    }
}
