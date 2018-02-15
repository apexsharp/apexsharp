namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Customer__c : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(18)]
		public string OwnerId {set;get;}
		[Ignore]
		public User Owner {set;get;}
		public bool IsDeleted {set;get;}
		[StringLength(80)]
		public string Name {set;get;}
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
		public DateTime LastViewedDate {set;get;}
		public DateTime LastReferencedDate {set;get;}
	}
}
