namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Organization : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(80)]
		public string Name {set;get;}
		[StringLength(80)]
		public string Division {set;get;}
		[StringLength(255)]
		public string Street {set;get;}
		[StringLength(40)]
		public string City {set;get;}
		[StringLength(80)]
		public string State {set;get;}
		[StringLength(20)]
		public string PostalCode {set;get;}
		[StringLength(80)]
		public string Country {set;get;}
		public double Latitude {set;get;}
		public double Longitude {set;get;}
		[StringLength(40)]
		public string GeocodeAccuracy {set;get;}
		public Address Address {set;get;}
		[StringLength(40)]
		public string Phone {set;get;}
		[StringLength(40)]
		public string Fax {set;get;}
		[StringLength(80)]
		public string PrimaryContact {set;get;}
		[StringLength(40)]
		public string DefaultLocaleSidKey {set;get;}
		[StringLength(40)]
		public string LanguageLocaleKey {set;get;}
		public bool ReceivesInfoEmails {set;get;}
		public bool ReceivesAdminInfoEmails {set;get;}
		public bool PreferencesRequireOpportunityProducts {set;get;}
		public bool PreferencesTransactionSecurityPolicy {set;get;}
		public bool PreferencesTerminateOldestSession {set;get;}
		public int FiscalYearStartMonth {set;get;}
		public bool UsesStartDateAsFiscalYearName {set;get;}
		[StringLength(40)]
		public string DefaultAccountAccess {set;get;}
		[StringLength(40)]
		public string DefaultContactAccess {set;get;}
		[StringLength(40)]
		public string DefaultOpportunityAccess {set;get;}
		[StringLength(40)]
		public string DefaultLeadAccess {set;get;}
		[StringLength(40)]
		public string DefaultCaseAccess {set;get;}
		[StringLength(40)]
		public string DefaultCalendarAccess {set;get;}
		[StringLength(40)]
		public string DefaultPricebookAccess {set;get;}
		[StringLength(40)]
		public string DefaultCampaignAccess {set;get;}
		public DateTime SystemModstamp {set;get;}
		[StringLength(80)]
		public string ComplianceBccEmail {set;get;}
		[StringLength(40)]
		public string UiSkin {set;get;}
		[StringLength(2)]
		public string SignupCountryIsoCode {set;get;}
		public DateTime TrialExpirationDate {set;get;}
		public int NumKnowledgeService {set;get;}
		[StringLength(40)]
		public string OrganizationType {set;get;}
		[StringLength(15)]
		public string NamespacePrefix {set;get;}
		[StringLength(5)]
		public string InstanceName {set;get;}
		public bool IsSandbox {set;get;}
		[StringLength(40)]
		public string WebToCaseDefaultOrigin {set;get;}
		public int MonthlyPageViewsUsed {set;get;}
		public int MonthlyPageViewsEntitlement {set;get;}
		public bool IsReadOnly {set;get;}
		public DateTime CreatedDate {set;get;}
		[StringLength(18)]
		public string CreatedById {set;get;}
		[Ignore]
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		[StringLength(18)]
		public string LastModifiedById {set;get;}
		[Ignore]
		public User LastModifiedBy {set;get;}
	}
}
