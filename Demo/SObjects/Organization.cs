namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Organization : SObject
	{
		public string Name {set;get;}
		public string Division {set;get;}
		public string Street {set;get;}
		public string City {set;get;}
		public string State {set;get;}
		public string PostalCode {set;get;}
		public string Country {set;get;}
		public double Latitude {set;get;}
		public double Longitude {set;get;}
		public string GeocodeAccuracy {set;get;}
		public Address Address {set;get;}
		public string Phone {set;get;}
		public string Fax {set;get;}
		public string PrimaryContact {set;get;}
		public string DefaultLocaleSidKey {set;get;}
		public string LanguageLocaleKey {set;get;}
		public bool ReceivesInfoEmails {set;get;}
		public bool ReceivesAdminInfoEmails {set;get;}
		public bool PreferencesRequireOpportunityProducts {set;get;}
		public bool PreferencesTransactionSecurityPolicy {set;get;}
		public bool PreferencesTerminateOldestSession {set;get;}
		public int FiscalYearStartMonth {set;get;}
		public bool UsesStartDateAsFiscalYearName {set;get;}
		public string DefaultAccountAccess {set;get;}
		public string DefaultContactAccess {set;get;}
		public string DefaultOpportunityAccess {set;get;}
		public string DefaultLeadAccess {set;get;}
		public string DefaultCaseAccess {set;get;}
		public string DefaultCalendarAccess {set;get;}
		public string DefaultPricebookAccess {set;get;}
		public string DefaultCampaignAccess {set;get;}
		public DateTime SystemModstamp {set;get;}
		public string ComplianceBccEmail {set;get;}
		public string UiSkin {set;get;}
		public string SignupCountryIsoCode {set;get;}
		public DateTime TrialExpirationDate {set;get;}
		public int NumKnowledgeService {set;get;}
		public string OrganizationType {set;get;}
		public string NamespacePrefix {set;get;}
		public string InstanceName {set;get;}
		public bool IsSandbox {set;get;}
		public string WebToCaseDefaultOrigin {set;get;}
		public int MonthlyPageViewsUsed {set;get;}
		public int MonthlyPageViewsEntitlement {set;get;}
		public bool IsReadOnly {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
	}
}
