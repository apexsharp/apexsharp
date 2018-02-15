namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class BankAccount__c : SObject
	{
		public bool IsDeleted {set;get;}
		public string Name {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public string CusCustomertomer__c {set;get;}
		public Customer__c CusCustomertomer__r {set;get;}
	}
}
