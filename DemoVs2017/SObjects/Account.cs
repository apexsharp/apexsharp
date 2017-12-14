using Apex.System;
using ApexSharpApi.ApexApi;

namespace DemoVs2017.SObjects
{
    public class Account : SObject
	{
		public bool IsDeleted {set;get;}
		public string MasterRecordId {set;get;}
		public Account MasterRecord {set;get;}
		public string Name {set;get;}
		public string Type {set;get;}
		public string ParentId {set;get;}
		public Account Parent {set;get;}
		public string BillingStreet {set;get;}
		public string BillingCity {set;get;}
		public string BillingState {set;get;}
		public string BillingPostalCode {set;get;}
		public string BillingCountry {set;get;}
		public double BillingLatitude {set;get;}
		public double BillingLongitude {set;get;}
		public string BillingGeocodeAccuracy {set;get;}
		public Address BillingAddress {set;get;}
		public string ShippingStreet {set;get;}
		public string ShippingCity {set;get;}
		public string ShippingState {set;get;}
		public string ShippingPostalCode {set;get;}
		public string ShippingCountry {set;get;}
		public double ShippingLatitude {set;get;}
		public double ShippingLongitude {set;get;}
		public string ShippingGeocodeAccuracy {set;get;}
		public Address ShippingAddress {set;get;}
		public string Phone {set;get;}
		public string Fax {set;get;}
		public string Website {set;get;}
		public string PhotoUrl {set;get;}
		public string Industry {set;get;}
		public double AnnualRevenue {set;get;}
		public int NumberOfEmployees {set;get;}
		public string Description {set;get;}
		public string OwnerId {set;get;}
		public User Owner {set;get;}
		public DateTime CreatedDate {set;get;}
		public string CreatedById {set;get;}
		public User CreatedBy {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public DateTime LastActivityDate {set;get;}
		public DateTime LastViewedDate {set;get;}
		public DateTime LastReferencedDate {set;get;}
		public string Jigsaw {set;get;}
		public string JigsawCompanyId {set;get;}
		public string AccountSource {set;get;}
		public string SicDesc {set;get;}
	}
}
