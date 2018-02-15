namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class DandBCompany : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		public bool IsDeleted {set;get;}
		[StringLength(255)]
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
		[StringLength(9)]
		public string DunsNumber {set;get;}
		[StringLength(255)]
		public string Street {set;get;}
		[StringLength(40)]
		public string City {set;get;}
		[StringLength(80)]
		public string State {set;get;}
		[StringLength(20)]
		public string PostalCode {set;get;}
		[StringLength(80)]
		public string Country {set;get;}
		[StringLength(255)]
		public string GeocodeAccuracyStandard {set;get;}
		public Address Address {set;get;}
		[StringLength(40)]
		public string Phone {set;get;}
		[StringLength(40)]
		public string Fax {set;get;}
		[StringLength(4)]
		public string CountryAccessCode {set;get;}
		[StringLength(255)]
		public string PublicIndicator {set;get;}
		[StringLength(6)]
		public string StockSymbol {set;get;}
		[StringLength(16)]
		public string StockExchange {set;get;}
		public double SalesVolume {set;get;}
		[StringLength(255)]
		public string URL {set;get;}
		[StringLength(255)]
		public string OutOfBusiness {set;get;}
		public double EmployeesTotal {set;get;}
		[StringLength(5)]
		public string FipsMsaCode {set;get;}
		[StringLength(255)]
		public string FipsMsaDesc {set;get;}
		[StringLength(255)]
		public string TradeStyle1 {set;get;}
		[StringLength(4)]
		public string YearStarted {set;get;}
		[StringLength(255)]
		public string MailingStreet {set;get;}
		[StringLength(40)]
		public string MailingCity {set;get;}
		[StringLength(80)]
		public string MailingState {set;get;}
		[StringLength(20)]
		public string MailingPostalCode {set;get;}
		[StringLength(80)]
		public string MailingCountry {set;get;}
		[StringLength(255)]
		public string MailingGeocodeAccuracy {set;get;}
		public Address MailingAddress {set;get;}
		[StringLength(11)]
		public string Latitude {set;get;}
		[StringLength(11)]
		public string Longitude {set;get;}
		[StringLength(4)]
		public string PrimarySic {set;get;}
		[StringLength(80)]
		public string PrimarySicDesc {set;get;}
		[StringLength(4)]
		public string SecondSic {set;get;}
		[StringLength(80)]
		public string SecondSicDesc {set;get;}
		[StringLength(4)]
		public string ThirdSic {set;get;}
		[StringLength(80)]
		public string ThirdSicDesc {set;get;}
		[StringLength(4)]
		public string FourthSic {set;get;}
		[StringLength(80)]
		public string FourthSicDesc {set;get;}
		[StringLength(4)]
		public string FifthSic {set;get;}
		[StringLength(80)]
		public string FifthSicDesc {set;get;}
		[StringLength(4)]
		public string SixthSic {set;get;}
		[StringLength(80)]
		public string SixthSicDesc {set;get;}
		[StringLength(6)]
		public string PrimaryNaics {set;get;}
		[StringLength(120)]
		public string PrimaryNaicsDesc {set;get;}
		[StringLength(6)]
		public string SecondNaics {set;get;}
		[StringLength(120)]
		public string SecondNaicsDesc {set;get;}
		[StringLength(6)]
		public string ThirdNaics {set;get;}
		[StringLength(120)]
		public string ThirdNaicsDesc {set;get;}
		[StringLength(6)]
		public string FourthNaics {set;get;}
		[StringLength(120)]
		public string FourthNaicsDesc {set;get;}
		[StringLength(6)]
		public string FifthNaics {set;get;}
		[StringLength(120)]
		public string FifthNaicsDesc {set;get;}
		[StringLength(6)]
		public string SixthNaics {set;get;}
		[StringLength(120)]
		public string SixthNaicsDesc {set;get;}
		[StringLength(255)]
		public string OwnOrRent {set;get;}
		public double EmployeesHere {set;get;}
		[StringLength(255)]
		public string EmployeesHereReliability {set;get;}
		[StringLength(255)]
		public string SalesVolumeReliability {set;get;}
		[StringLength(255)]
		public string CurrencyCode {set;get;}
		[StringLength(255)]
		public string LegalStatus {set;get;}
		public double GlobalUltimateTotalEmployees {set;get;}
		[StringLength(255)]
		public string EmployeesTotalReliability {set;get;}
		[StringLength(255)]
		public string MinorityOwned {set;get;}
		[StringLength(255)]
		public string WomenOwned {set;get;}
		[StringLength(255)]
		public string SmallBusiness {set;get;}
		[StringLength(255)]
		public string MarketingSegmentationCluster {set;get;}
		[StringLength(255)]
		public string ImportExportAgent {set;get;}
		[StringLength(255)]
		public string Subsidiary {set;get;}
		[StringLength(255)]
		public string TradeStyle2 {set;get;}
		[StringLength(255)]
		public string TradeStyle3 {set;get;}
		[StringLength(255)]
		public string TradeStyle4 {set;get;}
		[StringLength(255)]
		public string TradeStyle5 {set;get;}
		[StringLength(255)]
		public string NationalId {set;get;}
		[StringLength(255)]
		public string NationalIdType {set;get;}
		[StringLength(9)]
		public string UsTaxId {set;get;}
		[StringLength(255)]
		public string GeoCodeAccuracy {set;get;}
		public int FamilyMembers {set;get;}
		[StringLength(255)]
		public string MarketingPreScreen {set;get;}
		[StringLength(9)]
		public string GlobalUltimateDunsNumber {set;get;}
		[StringLength(255)]
		public string GlobalUltimateBusinessName {set;get;}
		[StringLength(9)]
		public string ParentOrHqDunsNumber {set;get;}
		[StringLength(255)]
		public string ParentOrHqBusinessName {set;get;}
		[StringLength(9)]
		public string DomesticUltimateDunsNumber {set;get;}
		[StringLength(255)]
		public string DomesticUltimateBusinessName {set;get;}
		[StringLength(255)]
		public string LocationStatus {set;get;}
		[StringLength(255)]
		public string CompanyCurrencyIsoCode {set;get;}
		[StringLength(32000)]
		public string Description {set;get;}
		public int FortuneRank {set;get;}
		[StringLength(10)]
		public string IncludedInSnP500 {set;get;}
		public int PremisesMeasure {set;get;}
		[StringLength(64)]
		public string PremisesMeasureReliability {set;get;}
		[StringLength(64)]
		public string PremisesMeasureUnit {set;get;}
		public double EmployeeQuantityGrowthRate {set;get;}
		public double SalesTurnoverGrowthRate {set;get;}
		[StringLength(8)]
		public string PrimarySic8 {set;get;}
		[StringLength(80)]
		public string PrimarySic8Desc {set;get;}
		[StringLength(8)]
		public string SecondSic8 {set;get;}
		[StringLength(80)]
		public string SecondSic8Desc {set;get;}
		[StringLength(8)]
		public string ThirdSic8 {set;get;}
		[StringLength(80)]
		public string ThirdSic8Desc {set;get;}
		[StringLength(8)]
		public string FourthSic8 {set;get;}
		[StringLength(80)]
		public string FourthSic8Desc {set;get;}
		[StringLength(8)]
		public string FifthSic8 {set;get;}
		[StringLength(80)]
		public string FifthSic8Desc {set;get;}
		[StringLength(8)]
		public string SixthSic8 {set;get;}
		[StringLength(80)]
		public string SixthSic8Desc {set;get;}
		public int PriorYearEmployees {set;get;}
		public double PriorYearRevenue {set;get;}
	}
}
