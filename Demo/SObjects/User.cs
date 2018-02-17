namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class User : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(80)]
		public string Username {set;get;}
		[StringLength(80)]
		public string LastName {set;get;}
		[StringLength(40)]
		public string FirstName {set;get;}
		[StringLength(121)]
		[IgnoreUpdate]
		public string Name {set;get;}
		[StringLength(80)]
		public string CompanyName {set;get;}
		[StringLength(80)]
		public string Division {set;get;}
		[StringLength(80)]
		public string Department {set;get;}
		[StringLength(80)]
		public string Title {set;get;}
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
		public double Latitude {set;get;}
		public double Longitude {set;get;}
		[StringLength(40)]
		public string GeocodeAccuracy {set;get;}
		[IgnoreUpdate]
		public Address Address {set;get;}
		[StringLength(128)]
		public string Email {set;get;}
		public bool EmailPreferencesAutoBcc {set;get;}
		public bool EmailPreferencesAutoBccStayInTouch {set;get;}
		public bool EmailPreferencesStayInTouchReminder {set;get;}
		[StringLength(80)]
		public string SenderEmail {set;get;}
		[StringLength(80)]
		public string SenderName {set;get;}
		[StringLength(1333)]
		public string Signature {set;get;}
		[StringLength(80)]
		public string StayInTouchSubject {set;get;}
		[StringLength(512)]
		public string StayInTouchSignature {set;get;}
		[StringLength(512)]
		public string StayInTouchNote {set;get;}
		[StringLength(40)]
		public string Phone {set;get;}
		[StringLength(40)]
		public string Fax {set;get;}
		[StringLength(40)]
		public string MobilePhone {set;get;}
		[StringLength(8)]
		public string Alias {set;get;}
		[StringLength(40)]
		public string CommunityNickname {set;get;}
		[StringLength(80)]
		[IgnoreUpdate]
		public string BadgeText {set;get;}
		public bool IsActive {set;get;}
		[StringLength(40)]
		public string TimeZoneSidKey {set;get;}
		[ApexId("UserRole")]
		[StringLength(18)]
		public string UserRoleId {set;get;}
		[Ignore]
		public UserRole UserRole {set;get;}
		[StringLength(40)]
		public string LocaleSidKey {set;get;}
		public bool ReceivesInfoEmails {set;get;}
		public bool ReceivesAdminInfoEmails {set;get;}
		[StringLength(40)]
		public string EmailEncodingKey {set;get;}
		[ApexId("Profile")]
		[StringLength(18)]
		public string ProfileId {set;get;}
		[Ignore]
		public Profile Profile {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string UserType {set;get;}
		[StringLength(40)]
		public string LanguageLocaleKey {set;get;}
		[StringLength(20)]
		public string EmployeeNumber {set;get;}
		[StringLength(18)]
		public string DelegatedApproverId {set;get;}
		[ApexId("Manager")]
		[StringLength(18)]
		public string ManagerId {set;get;}
		[Ignore]
		public User Manager {set;get;}
		[IgnoreUpdate]
		public DateTime LastLoginDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastPasswordChangeDate {set;get;}
		[IgnoreUpdate]
		public DateTime CreatedDate {set;get;}
		[ApexId("CreatedBy")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string CreatedById {set;get;}
		[Ignore]
		public User CreatedBy {set;get;}
		[IgnoreUpdate]
		public DateTime LastModifiedDate {set;get;}
		[ApexId("LastModifiedBy")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string LastModifiedById {set;get;}
		[Ignore]
		public User LastModifiedBy {set;get;}
		[IgnoreUpdate]
		public DateTime SystemModstamp {set;get;}
		[IgnoreUpdate]
		public DateTime OfflineTrialExpirationDate {set;get;}
		[IgnoreUpdate]
		public DateTime OfflinePdaTrialExpirationDate {set;get;}
		public bool UserPermissionsMarketingUser {set;get;}
		public bool UserPermissionsOfflineUser {set;get;}
		public bool UserPermissionsCallCenterAutoLogin {set;get;}
		public bool UserPermissionsMobileUser {set;get;}
		public bool UserPermissionsSFContentUser {set;get;}
		public bool UserPermissionsKnowledgeUser {set;get;}
		public bool UserPermissionsInteractionUser {set;get;}
		public bool UserPermissionsSupportUser {set;get;}
		public bool UserPermissionsJigsawProspectingUser {set;get;}
		public bool UserPermissionsSiteforceContributorUser {set;get;}
		public bool UserPermissionsSiteforcePublisherUser {set;get;}
		public bool UserPermissionsWorkDotComUserFeature {set;get;}
		public bool ForecastEnabled {set;get;}
		public bool UserPreferencesActivityRemindersPopup {set;get;}
		public bool UserPreferencesEventRemindersCheckboxDefault {set;get;}
		public bool UserPreferencesTaskRemindersCheckboxDefault {set;get;}
		public bool UserPreferencesReminderSoundOff {set;get;}
		public bool UserPreferencesDisableAllFeedsEmail {set;get;}
		public bool UserPreferencesDisableFollowersEmail {set;get;}
		public bool UserPreferencesDisableProfilePostEmail {set;get;}
		public bool UserPreferencesDisableChangeCommentEmail {set;get;}
		public bool UserPreferencesDisableLaterCommentEmail {set;get;}
		public bool UserPreferencesDisProfPostCommentEmail {set;get;}
		public bool UserPreferencesContentNoEmail {set;get;}
		public bool UserPreferencesContentEmailAsAndWhen {set;get;}
		public bool UserPreferencesApexPagesDeveloperMode {set;get;}
		public bool UserPreferencesHideCSNGetChatterMobileTask {set;get;}
		public bool UserPreferencesDisableMentionsPostEmail {set;get;}
		public bool UserPreferencesDisMentionsCommentEmail {set;get;}
		public bool UserPreferencesHideCSNDesktopTask {set;get;}
		public bool UserPreferencesHideChatterOnboardingSplash {set;get;}
		public bool UserPreferencesHideSecondChatterOnboardingSplash {set;get;}
		public bool UserPreferencesDisCommentAfterLikeEmail {set;get;}
		public bool UserPreferencesDisableLikeEmail {set;get;}
		public bool UserPreferencesSortFeedByComment {set;get;}
		public bool UserPreferencesDisableMessageEmail {set;get;}
		public bool UserPreferencesJigsawListUser {set;get;}
		public bool UserPreferencesDisableBookmarkEmail {set;get;}
		public bool UserPreferencesDisableSharePostEmail {set;get;}
		public bool UserPreferencesEnableAutoSubForFeeds {set;get;}
		public bool UserPreferencesDisableFileShareNotificationsForApi {set;get;}
		public bool UserPreferencesShowTitleToExternalUsers {set;get;}
		public bool UserPreferencesShowManagerToExternalUsers {set;get;}
		public bool UserPreferencesShowEmailToExternalUsers {set;get;}
		public bool UserPreferencesShowWorkPhoneToExternalUsers {set;get;}
		public bool UserPreferencesShowMobilePhoneToExternalUsers {set;get;}
		public bool UserPreferencesShowFaxToExternalUsers {set;get;}
		public bool UserPreferencesShowStreetAddressToExternalUsers {set;get;}
		public bool UserPreferencesShowCityToExternalUsers {set;get;}
		public bool UserPreferencesShowStateToExternalUsers {set;get;}
		public bool UserPreferencesShowPostalCodeToExternalUsers {set;get;}
		public bool UserPreferencesShowCountryToExternalUsers {set;get;}
		public bool UserPreferencesShowProfilePicToGuestUsers {set;get;}
		public bool UserPreferencesShowTitleToGuestUsers {set;get;}
		public bool UserPreferencesShowCityToGuestUsers {set;get;}
		public bool UserPreferencesShowStateToGuestUsers {set;get;}
		public bool UserPreferencesShowPostalCodeToGuestUsers {set;get;}
		public bool UserPreferencesShowCountryToGuestUsers {set;get;}
		public bool UserPreferencesDisableFeedbackEmail {set;get;}
		public bool UserPreferencesDisableWorkEmail {set;get;}
		public bool UserPreferencesHideS1BrowserUI {set;get;}
		public bool UserPreferencesDisableEndorsementEmail {set;get;}
		public bool UserPreferencesPathAssistantCollapsed {set;get;}
		public bool UserPreferencesCacheDiagnostics {set;get;}
		public bool UserPreferencesShowEmailToGuestUsers {set;get;}
		public bool UserPreferencesShowManagerToGuestUsers {set;get;}
		public bool UserPreferencesShowWorkPhoneToGuestUsers {set;get;}
		public bool UserPreferencesShowMobilePhoneToGuestUsers {set;get;}
		public bool UserPreferencesShowFaxToGuestUsers {set;get;}
		public bool UserPreferencesShowStreetAddressToGuestUsers {set;get;}
		public bool UserPreferencesLightningExperiencePreferred {set;get;}
		public bool UserPreferencesPreviewLightning {set;get;}
		public bool UserPreferencesHideEndUserOnboardingAssistantModal {set;get;}
		public bool UserPreferencesHideLightningMigrationModal {set;get;}
		public bool UserPreferencesHideSfxWelcomeMat {set;get;}
		public bool UserPreferencesHideBiggerPhotoCallout {set;get;}
		public bool UserPreferencesGlobalNavBarWTShown {set;get;}
		public bool UserPreferencesGlobalNavGridMenuWTShown {set;get;}
		public bool UserPreferencesCreateLEXAppsWTShown {set;get;}
		public bool UserPreferencesFavoritesWTShown {set;get;}
		public bool UserPreferencesRecordHomeSectionCollapseWTShown {set;get;}
		public bool UserPreferencesRecordHomeReservedWTShown {set;get;}
		public bool UserPreferencesFavoritesShowTopFavorites {set;get;}
		[ApexId("Contact")]
		[StringLength(18)]
		public string ContactId {set;get;}
		[Ignore]
		public Contact Contact {set;get;}
		[ApexId("Account")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string AccountId {set;get;}
		[Ignore]
		public Account Account {set;get;}
		[StringLength(18)]
		public string CallCenterId {set;get;}
		[StringLength(40)]
		public string Extension {set;get;}
		[StringLength(512)]
		public string FederationIdentifier {set;get;}
		[StringLength(1000)]
		public string AboutMe {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string FullPhotoUrl {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string SmallPhotoUrl {set;get;}
		[IgnoreUpdate]
		public bool IsExtIndicatorVisible {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string MediumPhotoUrl {set;get;}
		[StringLength(40)]
		public string DigestFrequency {set;get;}
		[StringLength(40)]
		public string DefaultGroupNotificationFrequency {set;get;}
		public int JigsawImportLimitOverride {set;get;}
		[IgnoreUpdate]
		public DateTime LastViewedDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastReferencedDate {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string BannerPhotoUrl {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string SmallBannerPhotoUrl {set;get;}
		[StringLength(1024)]
		[IgnoreUpdate]
		public string MediumBannerPhotoUrl {set;get;}
		[IgnoreUpdate]
		public bool IsProfilePhotoActive {set;get;}
	}
}
