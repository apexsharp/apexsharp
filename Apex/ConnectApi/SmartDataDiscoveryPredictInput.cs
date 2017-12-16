namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryPredictInput
    {
        // infrastructure
        public SmartDataDiscoveryPredictInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryPredictInput));
            }
        }

        // API
        object entityId
        {
            get
            {
                return Self.entityId;
            }
            set
            {
                Self.entityId = value;
            }
        }

        object predictionDefinitionId
        {
            get
            {
                return Self.predictionDefinitionId;
            }
            set
            {
                Self.predictionDefinitionId = value;
            }
        }

        public SmartDataDiscoveryPredictInput()
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
