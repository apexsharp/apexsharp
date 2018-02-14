namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Account : SObject
	{
        public string Name { set; get; }
		public DateTime CreatedDate {set;get;}
		public string LastModifiedDate {set;get;}
	    public Datetime LastViewedDate { set; get; }
    }
}
