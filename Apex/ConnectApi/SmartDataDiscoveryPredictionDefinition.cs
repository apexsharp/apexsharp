namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SmartDataDiscoveryPredictionDefinition
    {
        // infrastructure
        public SmartDataDiscoveryPredictionDefinition(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SmartDataDiscoveryPredictionDefinition));
            }
        }

        // API
        object countOfModels
        {
            get
            {
                return Self.countOfModels;
            }
            set
            {
                Self.countOfModels = value;
            }
        }

        object createdBy
        {
            get
            {
                return Self.createdBy;
            }
            set
            {
                Self.createdBy = value;
            }
        }

        object createdDate
        {
            get
            {
                return Self.createdDate;
            }
            set
            {
                Self.createdDate = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

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

        object lastModifiedBy
        {
            get
            {
                return Self.lastModifiedBy;
            }
            set
            {
                Self.lastModifiedBy = value;
            }
        }

        object lastModifiedDate
        {
            get
            {
                return Self.lastModifiedDate;
            }
            set
            {
                Self.lastModifiedDate = value;
            }
        }

        object modelsUrl
        {
            get
            {
                return Self.modelsUrl;
            }
            set
            {
                Self.modelsUrl = value;
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

        object predictionFieldId
        {
            get
            {
                return Self.predictionFieldId;
            }
            set
            {
                Self.predictionFieldId = value;
            }
        }

        object prescriptionsFieldId
        {
            get
            {
                return Self.prescriptionsFieldId;
            }
            set
            {
                Self.prescriptionsFieldId = value;
            }
        }

        object prescriptionsValueFieldId
        {
            get
            {
                return Self.prescriptionsValueFieldId;
            }
            set
            {
                Self.prescriptionsValueFieldId = value;
            }
        }

        object reasonsFieldId
        {
            get
            {
                return Self.reasonsFieldId;
            }
            set
            {
                Self.reasonsFieldId = value;
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

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        public SmartDataDiscoveryPredictionDefinition()
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
