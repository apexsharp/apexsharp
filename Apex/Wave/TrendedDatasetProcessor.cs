namespace Apex.Wave
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class TrendedDatasetProcessor
    {
        // infrastructure
        public TrendedDatasetProcessor(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TrendedDatasetProcessor));
            }
        }

        // API
        public string getDescription()
        {
            return Self.getDescription();
        }

        public string getLabel()
        {
            return Self.getLabel();
        }

        public void processTrendedDataset(ID param1, ID param2)
        {
            Self.processTrendedDataset(param1, param2);
        }
    }
}
