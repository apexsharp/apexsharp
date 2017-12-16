namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryPrediction
    {
        // infrastructure
        public SmartDataDiscoveryPrediction(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryPrediction));
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

        object exploratoryValues
        {
            get
            {
                return Self.exploratoryValues;
            }
            set
            {
                Self.exploratoryValues = value;
            }
        }

        object prediction
        {
            get
            {
                return Self.prediction;
            }
            set
            {
                Self.prediction = value;
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

        public SmartDataDiscoveryPrediction()
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
