namespace Apex.Database
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BatchableContextImpl
    {
        // infrastructure
        public BatchableContextImpl(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BatchableContextImpl));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public ID getChildJobId()
        {
            return Self.getChildJobId();
        }

        public ID getJobId()
        {
            return Self.getJobId();
        }
    }
}
