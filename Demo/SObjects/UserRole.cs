namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class UserRole : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(80)]
		public string Name {set;get;}
		[StringLength(18)]
		public string ParentRoleId {set;get;}
		[StringLength(80)]
		public string RollupDescription {set;get;}
		[StringLength(40)]
		public string OpportunityAccessForAccountOwner {set;get;}
		[StringLength(40)]
		public string CaseAccessForAccountOwner {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string ContactAccessForAccountOwner {set;get;}
		[StringLength(18)]
		public string ForecastUserId {set;get;}
		[IgnoreUpdate]
		public bool MayForecastManagerShare {set;get;}
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
		[StringLength(80)]
		public string DeveloperName {set;get;}
		[StringLength(18)]
		public string PortalAccountId {set;get;}
		[StringLength(40)]
		public string PortalType {set;get;}
		[StringLength(18)]
		[IgnoreUpdate]
		public string PortalAccountOwnerId {set;get;}
	}
}
