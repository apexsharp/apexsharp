namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Contact : SObject
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
		public Contact MasterRecord {set;get;}
		[ApexId("Account")]
		[StringLength(18)]
		public string AccountId {set;get;}
		[Ignore]
		public Account Account {set;get;}
		[StringLength(80)]
		public string LastName {set;get;}
		[StringLength(40)]
		public string FirstName {set;get;}
		[StringLength(40)]
		public string Salutation {set;get;}
		[StringLength(121)]
		[IgnoreUpdate]
		public string Name {set;get;}
		[StringLength(255)]
		public string OtherStreet {set;get;}
		[StringLength(40)]
		public string OtherCity {set;get;}
		[StringLength(80)]
		public string OtherState {set;get;}
		[StringLength(20)]
		public string OtherPostalCode {set;get;}
		[StringLength(80)]
		public string OtherCountry {set;get;}
		public double OtherLatitude {set;get;}
		public double OtherLongitude {set;get;}
		[StringLength(40)]
		public string OtherGeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address OtherAddress {set;get;}
		[StringLength(255)]
		public string MailingStreet {set;get;}
		[StringLength(40)]
		public string MailingCity {set;get;}
		[StringLength(80)]
		public string MailingState {set;get;}
		[StringLength(20)]
		public string MailingPostalCode {set;get;}
		[StringLength(80)]
		public string MailingCountry {set;get;}
		public double MailingLatitude {set;get;}
		public double MailingLongitude {set;get;}
		[StringLength(40)]
		public string MailingGeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address MailingAddress {set;get;}
		[StringLength(40)]
		public string Phone {set;get;}
		[StringLength(40)]
		public string Fax {set;get;}
		[StringLength(40)]
		public string MobilePhone {set;get;}
		[StringLength(40)]
		public string HomePhone {set;get;}
		[StringLength(40)]
		public string OtherPhone {set;get;}
		[StringLength(40)]
		public string AssistantPhone {set;get;}
		[ApexId("ReportsTo")]
		[StringLength(18)]
		public string ReportsToId {set;get;}
		[Ignore]
		public Contact ReportsTo {set;get;}
		[StringLength(80)]
		public string Email {set;get;}
		[StringLength(128)]
		public string Title {set;get;}
		[StringLength(80)]
		public string Department {set;get;}
		[StringLength(40)]
		public string AssistantName {set;get;}
		[StringLength(40)]
		public string LeadSource {set;get;}
		public DateTime Birthdate {set;get;}
		[StringLength(32000)]
		public string Description {set;get;}
		[ApexId("Owner")]
		[StringLength(18)]
		public string OwnerId {set;get;}
		[Ignore]
		public User Owner {set;get;}
		public bool HasOptedOutOfEmail {set;get;}
		public bool HasOptedOutOfFax {set;get;}
		public bool DoNotCall {set;get;}
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
		public DateTime LastCURequestDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastCUUpdateDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastViewedDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastReferencedDate {set;get;}
		[StringLength(255)]
		public string EmailBouncedReason {set;get;}
		public DateTime EmailBouncedDate {set;get;}
		[IgnoreUpdate]
		public bool IsEmailBounced {set;get;}
		[StringLength(255)]
		[IgnoreUpdate]
		public string PhotoUrl {set;get;}
		[StringLength(20)]
		public string Jigsaw {set;get;}
		[StringLength(20)]
		[IgnoreUpdate]
		public string JigsawContactId {set;get;}
		[StringLength(40)]
		public string CleanStatus {set;get;}
		[StringLength(255)]
		public string Level__c {set;get;}
		[StringLength(100)]
		public string Languages__c {set;get;}
	}
}
