using System;
using System.Xml.Serialization;

namespace ApexSharpApi.Model.BulkApi
{
    public class Rootobject
    {
        public string[] Property1 { get; set; }
    }

    public class BatchJobReply
    {
        public int apexProcessingTime { get; set; }
        public int apiActiveProcessingTime { get; set; }
        public DateTime createdDate { get; set; }
        public string id { get; set; }
        public string jobId { get; set; }
        public int numberRecordsFailed { get; set; }
        public int numberRecordsProcessed { get; set; }
        public string state { get; set; }
        public object stateMessage { get; set; }
        public DateTime systemModstamp { get; set; }
        public int totalProcessingTime { get; set; }
    }


    /// <remarks/>
    [Serializable()]
    [XmlRoot("jobInfo", Namespace = "http://www.force.com/2009/06/asyncapi/dataload")]
    public partial class JobInfoReply
    {
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
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

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
        public string createdById
        {
            get { return this.createdByIdField; }
            set { this.createdByIdField = value; }
        }

        /// <remarks/>
        public System.DateTime createdDate
        {
            get { return (DateTime)this.createdDateField; }
            set { this.createdDateField = value; }
        }

        /// <remarks/>
        public System.DateTime systemModstamp
        {
            get { return (DateTime)this.systemModstampField; }
            set { this.systemModstampField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
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

        /// <remarks/>
        public int numberBatchesQueued
        {
            get { return this.numberBatchesQueuedField; }
            set { this.numberBatchesQueuedField = value; }
        }

        /// <remarks/>
        public int numberBatchesInProgress
        {
            get { return this.numberBatchesInProgressField; }
            set { this.numberBatchesInProgressField = value; }
        }

        /// <remarks/>
        public int numberBatchesCompleted
        {
            get { return this.numberBatchesCompletedField; }
            set { this.numberBatchesCompletedField = value; }
        }

        /// <remarks/>
        public int numberBatchesFailed
        {
            get { return this.numberBatchesFailedField; }
            set { this.numberBatchesFailedField = value; }
        }

        /// <remarks/>
        public int numberBatchesTotal
        {
            get { return this.numberBatchesTotalField; }
            set { this.numberBatchesTotalField = value; }
        }

        /// <remarks/>
        public int numberRecordsProcessed
        {
            get { return this.numberRecordsProcessedField; }
            set { this.numberRecordsProcessedField = value; }
        }

        /// <remarks/>
        public int numberRetries
        {
            get { return this.numberRetriesField; }
            set { this.numberRetriesField = value; }
        }

        /// <remarks/>
        public decimal apiVersion
        {
            get { return this.apiVersionField; }
            set { this.apiVersionField = value; }
        }

        /// <remarks/>
        public int numberRecordsFailed
        {
            get { return this.numberRecordsFailedField; }
            set { this.numberRecordsFailedField = value; }
        }

        /// <remarks/>
        public int totalProcessingTime
        {
            get { return this.totalProcessingTimeField; }
            set { this.totalProcessingTimeField = value; }
        }

        /// <remarks/>
        public int apiActiveProcessingTime
        {
            get { return this.apiActiveProcessingTimeField; }
            set { this.apiActiveProcessingTimeField = value; }
        }

        /// <remarks/>
        public int apexProcessingTime
        {
            get { return this.apexProcessingTimeField; }
            set { this.apexProcessingTimeField = value; }
        }
    }
}