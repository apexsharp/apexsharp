namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Organization : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string Name {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string Division {set;get;}
		[StringLength(255)]
		[IgnoreUpdate]
		public string Street {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string City {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string State {set;get;}
		[StringLength(20)]
		[IgnoreUpdate]
		public string PostalCode {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string Country {set;get;}
		[IgnoreUpdate]
		public double Latitude {set;get;}
		[IgnoreUpdate]
		public double Longitude {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string GeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address Address {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string Phone {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string Fax {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string PrimaryContact {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultLocaleSidKey {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string LanguageLocaleKey {set;get;}
		[IgnoreUpdate]
		public bool ReceivesInfoEmails {set;get;}
		[IgnoreUpdate]
		public bool ReceivesAdminInfoEmails {set;get;}
		[IgnoreUpdate]
		public bool PreferencesRequireOpportunityProducts {set;get;}
		[IgnoreUpdate]
		public bool PreferencesTransactionSecurityPolicy {set;get;}
		[IgnoreUpdate]
		public bool PreferencesTerminateOldestSession {set;get;}
		[IgnoreUpdate]
		public int FiscalYearStartMonth {set;get;}
		[IgnoreUpdate]
		public bool UsesStartDateAsFiscalYearName {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultAccountAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultContactAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultOpportunityAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultLeadAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultCaseAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultCalendarAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultPricebookAccess {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string DefaultCampaignAccess {set;get;}
		[IgnoreUpdate]
		public DateTime SystemModstamp {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string ComplianceBccEmail {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string UiSkin {set;get;}
		[StringLength(2)]
		[IgnoreUpdate]
		public string SignupCountryIsoCode {set;get;}
		[IgnoreUpdate]
		public DateTime TrialExpirationDate {set;get;}
		[IgnoreUpdate]
		public int NumKnowledgeService {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string OrganizationType {set;get;}
		[StringLength(15)]
		[IgnoreUpdate]
		public string NamespacePrefix {set;get;}
		[StringLength(5)]
		[IgnoreUpdate]
		public string InstanceName {set;get;}
		[IgnoreUpdate]
		public bool IsSandbox {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string WebToCaseDefaultOrigin {set;get;}
		[IgnoreUpdate]
		public int MonthlyPageViewsUsed {set;get;}
		[IgnoreUpdate]
		public int MonthlyPageViewsEntitlement {set;get;}
		[IgnoreUpdate]
		public bool IsReadOnly {set;get;}
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
	}
}
