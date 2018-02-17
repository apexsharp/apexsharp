namespace Demo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;
	using ApexSharpApi.Attributes;
	using ServiceStack.DataAnnotations;
	using DateTime = global::System.DateTime;

	public class Profile : SObject
	{
		[PrimaryKey]
		[AutoIncrement]
		public int ExternalId {set;get;}
		[StringLength(255)]
		[IgnoreUpdate]
		public string Name {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEmailSingle {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEmailMass {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditTask {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditEvent {set;get;}
		[IgnoreUpdate]
		public bool PermissionsExportReport {set;get;}
		[IgnoreUpdate]
		public bool PermissionsImportPersonal {set;get;}
		[IgnoreUpdate]
		public bool PermissionsDataExport {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditPublicTemplates {set;get;}
		[IgnoreUpdate]
		public bool PermissionsModifyAllData {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCases {set;get;}
		[IgnoreUpdate]
		public bool PermissionsMassInlineEdit {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditKnowledge {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageKnowledge {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageSolutions {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCustomizeApplication {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditReadonlyFields {set;get;}
		[IgnoreUpdate]
		public bool PermissionsRunReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewSetup {set;get;}
		[IgnoreUpdate]
		public bool PermissionsTransferAnyEntity {set;get;}
		[IgnoreUpdate]
		public bool PermissionsNewReportBuilder {set;get;}
		[IgnoreUpdate]
		public bool PermissionsActivateContract {set;get;}
		[IgnoreUpdate]
		public bool PermissionsActivateOrder {set;get;}
		[IgnoreUpdate]
		public bool PermissionsImportLeads {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageLeads {set;get;}
		[IgnoreUpdate]
		public bool PermissionsTransferAnyLead {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewAllData {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditPublicDocuments {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewEncryptedData {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditBrandTemplates {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditHtmlTemplates {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterInternalUser {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageEncryptionKeys {set;get;}
		[IgnoreUpdate]
		public bool PermissionsDeleteActivatedContract {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterInviteExternalUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSendSitRequests {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageRemoteAccess {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCanUseNewDashboardBuilder {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCategories {set;get;}
		[IgnoreUpdate]
		public bool PermissionsConvertLeads {set;get;}
		[IgnoreUpdate]
		public bool PermissionsPasswordNeverExpires {set;get;}
		[IgnoreUpdate]
		public bool PermissionsUseTeamReassignWizards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditActivatedOrders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsInstallMultiforce {set;get;}
		[IgnoreUpdate]
		public bool PermissionsPublishMultiforce {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterOwnGroups {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditOppLineItemUnitPrice {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateMultiforce {set;get;}
		[IgnoreUpdate]
		public bool PermissionsBulkApiHardDelete {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSolutionImport {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCallCenters {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageSynonyms {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewContent {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageEmailClientConfig {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEnableNotifications {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageDataIntegrations {set;get;}
		[IgnoreUpdate]
		public bool PermissionsDistributeFromPersWksp {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewDataCategories {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageDataCategories {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAuthorApex {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageMobile {set;get;}
		[IgnoreUpdate]
		public bool PermissionsApiEnabled {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCustomReportTypes {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditCaseComments {set;get;}
		[IgnoreUpdate]
		public bool PermissionsTransferAnyCase {set;get;}
		[IgnoreUpdate]
		public bool PermissionsContentAdministrator {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateWorkspaces {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageContentPermissions {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageContentProperties {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageContentTypes {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageExchangeConfig {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageAnalyticSnapshots {set;get;}
		[IgnoreUpdate]
		public bool PermissionsScheduleReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageBusinessHourHolidays {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageDynamicDashboards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCustomSidebarOnAllPages {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageInteraction {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewMyTeamsDashboards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsModerateChatter {set;get;}
		[IgnoreUpdate]
		public bool PermissionsResetPasswords {set;get;}
		[IgnoreUpdate]
		public bool PermissionsFlowUFLRequired {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCanInsertFeedSystemFields {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageKnowledgeImportExport {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEmailTemplateManagement {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEmailAdministration {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageChatterMessages {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAllowEmailIC {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterFileLink {set;get;}
		[IgnoreUpdate]
		public bool PermissionsForceTwoFactor {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewEventLogFiles {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageNetworks {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageAuthProviders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsRunFlow {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateCustomizeDashboards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateDashboardFolders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewPublicDashboards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageDashbdsInPubFolders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateCustomizeReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateReportFolders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewPublicReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageReportsInPubFolders {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditMyDashboards {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditMyReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewAllUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAllowUniversalSearch {set;get;}
		[IgnoreUpdate]
		public bool PermissionsConnectOrgToEnvironmentHub {set;get;}
		[IgnoreUpdate]
		public bool PermissionsWorkCalibrationUser {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateCustomizeFilters {set;get;}
		[IgnoreUpdate]
		public bool PermissionsWorkDotComUserPerm {set;get;}
		[IgnoreUpdate]
		public bool PermissionsGovernNetworks {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSalesConsole {set;get;}
		[IgnoreUpdate]
		public bool PermissionsTwoFactorApi {set;get;}
		[IgnoreUpdate]
		public bool PermissionsDeleteTopics {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEditTopics {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateTopics {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAssignTopics {set;get;}
		[IgnoreUpdate]
		public bool PermissionsIdentityEnabled {set;get;}
		[IgnoreUpdate]
		public bool PermissionsIdentityConnect {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAllowViewKnowledge {set;get;}
		[IgnoreUpdate]
		public bool PermissionsContentWorkspaces {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageSearchPromotionRules {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCustomMobileAppsAccess {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewHelpLink {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageProfilesPermissionsets {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAssignPermissionSets {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageRoles {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageIpAddresses {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageSharing {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageInternalUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManagePasswordPolicies {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageLoginAccessPolicies {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCustomPermissions {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageUnlistedGroups {set;get;}
		[IgnoreUpdate]
		public bool PermissionsModifySecureAgents {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageTwoFactor {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterForSharePoint {set;get;}
		[IgnoreUpdate]
		public bool PermissionsLightningExperienceUser {set;get;}
		[IgnoreUpdate]
		public bool PermissionsConfigCustomRecs {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSubmitMacrosAllowed {set;get;}
		[IgnoreUpdate]
		public bool PermissionsBulkMacrosAllowed {set;get;}
		[IgnoreUpdate]
		public bool PermissionsShareInternalArticles {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageSessionPermissionSets {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSendAnnouncementEmails {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterEditOwnPost {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterEditOwnRecordPost {set;get;}
		[IgnoreUpdate]
		public bool PermissionsImportCustomObjects {set;get;}
		[IgnoreUpdate]
		public bool PermissionsDelegatedTwoFactor {set;get;}
		[IgnoreUpdate]
		public bool PermissionsChatterComposeUiCodesnippet {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSelectFilesFromSalesforce {set;get;}
		[IgnoreUpdate]
		public bool PermissionsModerateNetworkUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsMergeTopics {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSubscribeToLightningReports {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManagePvtRptsAndDashbds {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCampaignInfluence2 {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewDataAssessment {set;get;}
		[IgnoreUpdate]
		public bool PermissionsRemoveDirectMessageMembers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCanApproveFeedPost {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAddDirectMessageMembers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAllowViewEditConvertedLeads {set;get;}
		[IgnoreUpdate]
		public bool PermissionsShowCompanyNameAsUserBadge {set;get;}
		[IgnoreUpdate]
		public bool PermissionsAccessCMC {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewHealthCheck {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageHealthCheck {set;get;}
		[IgnoreUpdate]
		public bool PermissionsManageCertificates {set;get;}
		[IgnoreUpdate]
		public bool PermissionsCreateReportInLightning {set;get;}
		[IgnoreUpdate]
		public bool PermissionsPreventClassicExperience {set;get;}
		[IgnoreUpdate]
		public bool PermissionsHideReadByList {set;get;}
		[IgnoreUpdate]
		public bool PermissionsViewAllActivities {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSubscribeReportToOtherUsers {set;get;}
		[IgnoreUpdate]
		public bool PermissionsLightningConsoleAllowedForUser {set;get;}
		[IgnoreUpdate]
		public bool PermissionsSubscribeReportsRunAsUser {set;get;}
		[IgnoreUpdate]
		public bool PermissionsEnableCommunityAppLauncher {set;get;}
		[ApexId("UserLicense")]
		[StringLength(18)]
		[IgnoreUpdate]
		public string UserLicenseId {set;get;}
		[Ignore]
		public UserLicense UserLicense {set;get;}
		[StringLength(40)]
		[IgnoreUpdate]
		public string UserType {set;get;}
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
		[StringLength(255)]
		[IgnoreUpdate]
		public string Description {set;get;}
		[IgnoreUpdate]
		public DateTime LastViewedDate {set;get;}
		[IgnoreUpdate]
		public DateTime LastReferencedDate {set;get;}
	}
}
