namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class UserLicense : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string LicenseDefinitionKey {set;get;}
		[IgnoreUpdate]
		public int TotalLicenses {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string Status {set;get;}
		[IgnoreUpdate]
		public int UsedLicenses {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string Name {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string MasterLabel {set;get;}
		[IgnoreUpdate]
		public int MonthlyLoginsUsed {set;get;}
		[IgnoreUpdate]
		public int MonthlyLoginsEntitlement {set;get;}
		[IgnoreUpdate]
		public DateTime CreatedDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastModifiedDate {set;get;}
		[IgnoreUpdate]
		public DateTime SystemModstamp {set;get;}
	}
}
