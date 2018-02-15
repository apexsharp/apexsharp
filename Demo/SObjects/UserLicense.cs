namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class UserLicense : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(40)]
		public string LicenseDefinitionKey {set;get;}
		public int TotalLicenses {set;get;}
		[StringLength(40)]
		public string Status {set;get;}
		public int UsedLicenses {set;get;}
		[StringLength(40)]
		public string Name {set;get;}
		[StringLength(80)]
		public string MasterLabel {set;get;}
		public int MonthlyLoginsUsed {set;get;}
		public int MonthlyLoginsEntitlement {set;get;}
		public DateTime CreatedDate {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public DateTime SystemModstamp {set;get;}
	}
}
