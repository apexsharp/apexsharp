namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Contact : SObject
	{
		public bool IsDeleted {set;get;}
		public string MasterRecordId {set;get;}
		public Contact MasterRecord {set;get;}
		public string AccountId {set;get;}
		public Account Account {set;get;}
		public string LastName {set;get;}
		public string FirstName {set;get;}
		public string Salutation {set;get;}
		public string Name {set;get;}
		public string OtherStreet {set;get;}
		public string OtherCity {set;get;}
		public string OtherState {set;get;}
		public string OtherPostalCode {set;get;}
		public string OtherCountry {set;get;}
		public double OtherLatitude {set;get;}
		public double OtherLongitude {set;get;}
		public string OtherGeocodeAccuracy {set;get;}
		public Address OtherAddress {set;get;}
		public string MailingStreet {set;get;}
		public string MailingCity {set;get;}
		public string MailingState {set;get;}
		public string MailingPostalCode {set;get;}
		public string MailingCountry {set;get;}
		public double MailingLatitude {set;get;}
		public double MailingLongitude {set;get;}
		public string MailingGeocodeAccuracy {set;get;}
		public Address MailingAddress {set;get;}
		public string Phone {set;get;}
		public string Fax {set;get;}
		public string MobilePhone {set;get;}
		public string HomePhone {set;get;}
		public string OtherPhone {set;get;}
		public string AssistantPhone {set;get;}
		public string ReportsToId {set;get;}
		public Contact ReportsTo {set;get;}
		public string Email {set;get;}
		public string Title {set;get;}
		public string Department {set;get;}
		public string AssistantName {set;get;}
		public string LeadSource {set;get;}
		public Datetime Birthdate {set;get;}
		public string Description {set;get;}
		public string OwnerId {set;get;}
		public User Owner {set;get;}
		public bool HasOptedOutOfEmail {set;get;}
		public bool HasOptedOutOfFax {set;get;}
		public bool DoNotCall {set;get;}
		public Datetime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public Datetime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public Datetime SystemModstamp {set;get;}
		public Datetime LastActivityDate {set;get;}
		public Datetime LastCURequestDate {set;get;}
		public Datetime LastCUUpdateDate {set;get;}
		public Datetime LastViewedDate {set;get;}
		public Datetime LastReferencedDate {set;get;}
		public string EmailBouncedReason {set;get;}
		public Datetime EmailBouncedDate {set;get;}
		public bool IsEmailBounced {set;get;}
		public string PhotoUrl {set;get;}
		public string Jigsaw {set;get;}
		public string JigsawContactId {set;get;}
		public string CleanStatus {set;get;}
		public string Level__c {set;get;}
		public string Languages__c {set;get;}
	}
}
