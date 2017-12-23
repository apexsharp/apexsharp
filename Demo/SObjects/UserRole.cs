using System;

namespace Demo.SObjects
{
	using Apex.System;
	

	public class UserRole : SObject
	{
		public string Name {set;get;}
		public string ParentRoleId {set;get;}
		public string RollupDescription {set;get;}
		public string OpportunityAccessForAccountOwner {set;get;}
		public string CaseAccessForAccountOwner {set;get;}
		public string ContactAccessForAccountOwner {set;get;}
		public string ForecastUserId {set;get;}
		public bool MayForecastManagerShare {set;get;}
		public DateTime LastModifiedDate {set;get;}
		public string LastModifiedById {set;get;}
		public User LastModifiedBy {set;get;}
		public DateTime SystemModstamp {set;get;}
		public string DeveloperName {set;get;}
		public string PortalAccountId {set;get;}
		public string PortalType {set;get;}
		public string PortalAccountOwnerId {set;get;}
	}
}
