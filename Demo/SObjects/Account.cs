using ServiceStack.DataAnnotations;

namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Account : SObject
	{
		public bool IsDeleted {set;get;}

	    [StringLength(18)]
        public string MasterRecordId {set;get;}
	    [Ignore]
        public Account MasterRecord {set;get;}

		public string Name {set;get;}
		public string Type {set;get;}

	    [StringLength(18)]
        public string ParentId {set;get;}
	    [Ignore]
        public Account Parent {set;get;}


		public string BillingStreet {set;get;}
		public string BillingCity {set;get;}
		public string BillingState {set;get;}
		public string BillingPostalCode {set;get;}
		public string BillingCountry {set;get;}
		public double BillingLatitude {set;get;}
		public double BillingLongitude {set;get;}
		public string BillingGeocodeAccuracy {set;get;}
		public Address BillingAddress {set;get;}
		public string ShippingStreet {set;get;}
		public string ShippingCity {set;get;}
		public string ShippingState {set;get;}
		public string ShippingPostalCode {set;get;}
		public string ShippingCountry {set;get;}
		public double ShippingLatitude {set;get;}
		public double ShippingLongitude {set;get;}
		public string ShippingGeocodeAccuracy {set;get;}
		public Address ShippingAddress {set;get;}
		public string Phone {set;get;}
		public string Fax {set;get;}
		public string AccountNumber {set;get;}
		public string Website {set;get;}
		public string PhotoUrl {set;get;}
		public string Sic {set;get;}
		public string Industry {set;get;}
		public double AnnualRevenue {set;get;}
		public int NumberOfEmployees {set;get;}
		public string Ownership {set;get;}
		public string TickerSymbol {set;get;}
		public string Description {set;get;}
		public string Rating {set;get;}
		public string Site {set;get;}
		public string OwnerId {set;get;}
		public User Owner {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public DateTime LastActivityDate {set;get;}
		public DateTime LastViewedDate {set;get;}
		public DateTime LastReferencedDate {set;get;}
		public string Jigsaw {set;get;}
		public string JigsawCompanyId {set;get;}
		public string CleanStatus {set;get;}
		public string AccountSource {set;get;}
		public string DunsNumber {set;get;}
		public string Tradestyle {set;get;}
		public string NaicsCode {set;get;}
		public string NaicsDesc {set;get;}
		public string YearStarted {set;get;}
		public string SicDesc {set;get;}
		public string DandbCompanyId {set;get;}
		public DandBCompany DandbCompany {set;get;}
		public string CustomerPriority__c {set;get;}
		public string SLA__c {set;get;}
		public string Active__c {set;get;}
		public double NumberofLocations__c {set;get;}
		public string UpsellOpportunity__c {set;get;}
		public string SLASerialNumber__c {set;get;}
		public DateTime SLAExpirationDate__c {set;get;}
	}
}
