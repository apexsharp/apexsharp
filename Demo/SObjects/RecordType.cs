namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class RecordType : SObject
	{
		public string Name {set;get;}
		public string DeveloperName {set;get;}
		public string NamespacePrefix {set;get;}
		public string Description {set;get;}
		public string BusinessProcessId {set;get;}
		public string SobjectType {set;get;}
		public bool IsActive {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime CreatedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public DateTime SystemModstamp {set;get;}
	}
}
