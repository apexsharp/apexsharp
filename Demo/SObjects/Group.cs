namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Group : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(40)]
		public string Name {set;get;}
		[StringLength(80)]
		public string DeveloperName {set;get;}
		[ApexId("Related")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string RelatedId {set;get;}
		[Ignore]
		public User Related {set;get;}
		[StringLength(40)]
		public string Type {set;get;}
		[StringLength(255)]
		public string Email {set;get;}
		[ApexId("Owner")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string OwnerId {set;get;}
		[Ignore]
		public User Owner {set;get;}
		public bool DoesSendEmailToMembers {set;get;}
		public bool DoesIncludeBosses {set;get;}
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
	}
}
