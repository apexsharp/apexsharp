namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class UserLicense : SObject
	{
		public string LicenseDefinitionKey {set;get;}
		public int TotalLicenses {set;get;}
		public string Status {set;get;}
		public int UsedLicenses {set;get;}
		public string Name {set;get;}
		public string MasterLabel {set;get;}
		public int MonthlyLoginsUsed {set;get;}
		public int MonthlyLoginsEntitlement {set;get;}
		public Datetime CreatedDate {set;get;}
		public Datetime LastModifiedDate {set;get;}
		public Datetime SystemModstamp {set;get;}
	}
}
