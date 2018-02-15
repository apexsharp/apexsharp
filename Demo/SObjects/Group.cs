namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
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
		[StringLength(18)]
		public string RelatedId {set;get;}
		[Ignore]
		public User Related {set;get;}
		[StringLength(40)]
		public string Type {set;get;}
		[StringLength(255)]
		public string Email {set;get;}
		[StringLength(18)]
		public string OwnerId {set;get;}
		[Ignore]
		public User Owner {set;get;}
		public bool DoesSendEmailToMembers {set;get;}
		public bool DoesIncludeBosses {set;get;}
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
		public DateTime SystemModstamp {set;get;}
	}
}
