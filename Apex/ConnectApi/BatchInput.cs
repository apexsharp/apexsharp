namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class BatchInput
    {
        // infrastructure
        public BatchInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(BatchInput));
            }
        }

        // API
        ////public BatchInput(object input)
        ////{
        ////    Implementation.Constructor(input);
        ////}

        public BatchInput(object input, BinaryInput binary)
        {
            Implementation.Constructor(input, binary);
        }

        public BatchInput(object input, List<BinaryInput> binaries)
        {
            Implementation.Constructor(input, binaries);
        }

        public object clone()
        {
            return Self.clone();
        }

        public List<BinaryInput> getBinaries()
        {
            return Self.getBinaries();
        }

        public object getInput()
        {
            return Self.getInput();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
