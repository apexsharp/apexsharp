namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Group : SObject
	{
		public string Name {set;get;}
		public string DeveloperName {set;get;}
		public string RelatedId {set;get;}
		public User Related {set;get;}
		public string Type {set;get;}
		public string Email {set;get;}
		public string OwnerId {set;get;}
		public User Owner {set;get;}
		public bool DoesSendEmailToMembers {set;get;}
		public bool DoesIncludeBosses {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
	}
}
