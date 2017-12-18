namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryPredictionDefinitionInput
    {
        // infrastructure
        public SmartDataDiscoveryPredictionDefinitionInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryPredictionDefinitionInput));
            }
        }

        // API
        object isActive
        {
            get
            {
                return Self.isActive;
            }
            set
            {
                Self.isActive = value;
            }
        }

        object isWritingToEntity
        {
            get
            {
                return Self.isWritingToEntity;
            }
            set
            {
                Self.isWritingToEntity = value;
            }
        }

        object label
        {
            get
            {
                return Self.label;
            }
            set
            {
                Self.label = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object outcomeField
        {
            get
            {
                return Self.outcomeField;
            }
            set
            {
                Self.outcomeField = value;
            }
        }

        object outcomeFieldLabel
        {
            get
            {
                return Self.outcomeFieldLabel;
            }
            set
            {
                Self.outcomeFieldLabel = value;
            }
        }

        object outcomeGoal
        {
            get
            {
                return Self.outcomeGoal;
            }
            set
            {
                Self.outcomeGoal = value;
            }
        }

        object subscribedEntity
        {
            get
            {
                return Self.subscribedEntity;
            }
            set
            {
                Self.subscribedEntity = value;
            }
        }

        public SmartDataDiscoveryPredictionDefinitionInput()
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
