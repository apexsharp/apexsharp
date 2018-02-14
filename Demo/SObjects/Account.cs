namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using DateTime = global::System.DateTime;

	public class Account : SObject
	{
        public string Name { set; get; }
		public DateTime CreatedDate {set;get;}
		public DateTime LastModifiedDate {set;get;}
	    public DateTime LastViewedDate { set; get; }
    }
}
