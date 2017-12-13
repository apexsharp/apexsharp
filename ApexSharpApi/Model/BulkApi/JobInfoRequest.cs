using System.Xml.Serialization;

namespace ApexSharpApi.Model.BulkApi
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [XmlRoot("jobInfo", Namespace = "http://www.force.com/2009/06/asyncapi/dataload")]
    public partial class JobInfoRequest
    {
#pragma warning disable 0169
        private int apexProcessingTimeField;

        private int apiActiveProcessingTimeField;

        private decimal apiVersionField;

        private string concurrencyModeField;

        private string contentTypeField;

        private string createdByIdField;

        private System.DateTime? createdDateField;

        private string idField;

        private int numberBatchesCompletedField;

        private int numberBatchesFailedField;

        private int numberBatchesInProgressField;

        private int numberBatchesQueuedField;

        private int numberBatchesTotalField;

        private int numberRecordsFailedField;

        private int numberRecordsProcessedField;

        private int numberRetriesField;

        private string objectField;

        private string operationField;

        private string stateField;

        private System.DateTime? systemModstampField;

        private int totalProcessingTimeField;

        /// <remarks/>
        public string operation
        {
            get { return this.operationField; }
            set { this.operationField = value; }
        }

        /// <remarks/>
        public string @object
        {
            get { return this.objectField; }
            set { this.objectField = value; }
        }


        /// <remarks/>
        public string concurrencyMode
        {
            get { return this.concurrencyModeField; }
            set { this.concurrencyModeField = value; }
        }

        /// <remarks/>
        public string contentType
        {
            get { return this.contentTypeField; }
            set { this.contentTypeField = value; }
        }
#pragma warning restore 0169
    }
}