namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Account : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[IgnoreUpdate]
		public bool IsDeleted {set;get;}
		[ApexId("MasterRecord")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string MasterRecordId {set;get;}
		[Ignore]
		public Account MasterRecord {set;get;}
		[StringLength(255)]
		public string Name {set;get;}
		[StringLength(40)]
		public string Type {set;get;}
		[ApexId("Parent")]
		[StringLength(18)]
		public string ParentId {set;get;}
		[Ignore]
		public Account Parent {set;get;}
		[StringLength(255)]
		public string BillingStreet {set;get;}
		[StringLength(40)]
		public string BillingCity {set;get;}
		[StringLength(80)]
		public string BillingState {set;get;}
		[StringLength(20)]
		public string BillingPostalCode {set;get;}
		[StringLength(80)]
		public string BillingCountry {set;get;}
		public double BillingLatitude {set;get;}
		public double BillingLongitude {set;get;}
		[StringLength(40)]
		public string BillingGeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address BillingAddress {set;get;}
		[StringLength(255)]
		public string ShippingStreet {set;get;}
		[StringLength(40)]
		public string ShippingCity {set;get;}
		[StringLength(80)]
		public string ShippingState {set;get;}
		[StringLength(20)]
		public string ShippingPostalCode {set;get;}
		[StringLength(80)]
		public string ShippingCountry {set;get;}
		public double ShippingLatitude {set;get;}
		public double ShippingLongitude {set;get;}
		[StringLength(40)]
		public string ShippingGeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address ShippingAddress {set;get;}
		[StringLength(40)]
		public string Phone {set;get;}
		[StringLength(40)]
		public string Fax {set;get;}
		[StringLength(40)]
		public string AccountNumber {set;get;}
		[StringLength(255)]
		public string Website {set;get;}
		[StringLength(255)]
		[IgnoreUpdate]
		public string PhotoUrl {set;get;}
		[StringLength(20)]
		public string Sic {set;get;}
		[StringLength(40)]
		public string Industry {set;get;}
		public double AnnualRevenue {set;get;}
		public int NumberOfEmployees {set;get;}
		[StringLength(40)]
		public string Ownership {set;get;}
		[StringLength(20)]
		public string TickerSymbol {set;get;}
		[StringLength(32000)]
		public string Description {set;get;}
		[StringLength(40)]
		public string Rating {set;get;}
		[StringLength(80)]
		public string Site {set;get;}
		[ApexId("Owner")]
		[StringLength(18)]
		public string OwnerId {set;get;}
		[Ignore]
		public User Owner {set;get;}
		[IgnoreUpdate]
		public DateTime CreatedDate {set;get;}
		[ApexId("CreatedBy")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string CreatedById {set;get;}
		[Ignore]
		public User CreatedBy {set;get;}
		[IgnoreUpdate]
		public DateTime LastModifiedDate {set;get;}
		[ApexId("LastModifiedBy")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string LastModifiedById {set;get;}
		[Ignore]
		public User LastModifiedBy {set;get;}
		[IgnoreUpdate]
		public DateTime SystemModstamp {set;get;}
		[IgnoreUpdate]
		public DateTime LastActivityDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastViewedDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastReferencedDate {set;get;}
		[StringLength(20)]
		public string Jigsaw {set;get;}
		[StringLength(20)]
		[IgnoreUpdate]
		public string JigsawCompanyId {set;get;}
		[StringLength(40)]
		public string CleanStatus {set;get;}
		[StringLength(40)]
		public string AccountSource {set;get;}
		[StringLength(9)]
		public string DunsNumber {set;get;}
		[StringLength(255)]
		public string Tradestyle {set;get;}
		[StringLength(8)]
		public string NaicsCode {set;get;}
		[StringLength(120)]
		public string NaicsDesc {set;get;}
		[StringLength(4)]
		public string YearStarted {set;get;}
		[StringLength(80)]
		public string SicDesc {set;get;}
		[ApexId("DandbCompany")]
		[StringLength(18)]
		public string DandbCompanyId {set;get;}
		[Ignore]
		public DandBCompany DandbCompany {set;get;}
		[StringLength(255)]
		public string CustomerPriority__c {set;get;}
		[StringLength(255)]
		public string SLA__c {set;get;}
		[StringLength(255)]
		public string Active__c {set;get;}
		public double NumberofLocations__c {set;get;}
		[StringLength(255)]
		public string UpsellOpportunity__c {set;get;}
		[StringLength(10)]
		public string SLASerialNumber__c {set;get;}
		[IgnoreUpdate]
		public DateTime SLAExpirationDate__c {set;get;}
	}
}
