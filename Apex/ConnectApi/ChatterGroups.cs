namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ChatterGroups_static_methods.htm#apex_ConnectAPI_ChatterGroups_static_methods
    /// </summary>
    public class ChatterGroups
    {
        // infrastructure
        public ChatterGroups(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterGroups));
            }
        }

        // API
        public static GroupMember addMember(string communityId, string groupId, string userId)
        {
            return Implementation.addMember(communityId, groupId, userId);
        }

        public static GroupMember addMemberWithRole(string communityId, string groupId, string userId, GroupMembershipType role)
        {
            return Implementation.addMemberWithRole(communityId, groupId, userId, role);
        }

        public static GroupRecord addRecord(string communityId, string groupId, string recordId)
        {
            return Implementation.addRecord(communityId, groupId, recordId);
        }

        public static ChatterGroupDetail createGroup(string communityId, ChatterGroupInput groupInput)
        {
            return Implementation.createGroup(communityId, groupInput);
        }

        public static void deleteBannerPhoto(string communityId, string groupId)
        {
            Implementation.deleteBannerPhoto(communityId, groupId);
        }

        public static void deleteGroup(string communityId, string groupId)
        {
            Implementation.deleteGroup(communityId, groupId);
        }

        public static void deleteMember(string communityId, string membershipId)
        {
            Implementation.deleteMember(communityId, membershipId);
        }

        public static void deletePhoto(string communityId, string groupId)
        {
            Implementation.deletePhoto(communityId, groupId);
        }

        public static AnnouncementPage getAnnouncements(string communityId, string groupId)
        {
            return Implementation.getAnnouncements(communityId, groupId);
        }

        public static AnnouncementPage getAnnouncements(string communityId, string groupId, int pageParam, int pageSize)
        {
            return Implementation.getAnnouncements(communityId, groupId, pageParam, pageSize);
        }

        public static BannerPhoto getBannerPhoto(string communityId, string groupId)
        {
            return Implementation.getBannerPhoto(communityId, groupId);
        }

        public static ChatterGroupDetail getGroup(string communityId, string groupId)
        {
            return Implementation.getGroup(communityId, groupId);
        }

        public static BatchResult[] getGroupBatch(string communityId, List<string> groupIds)
        {
            return Implementation.getGroupBatch(communityId, groupIds);
        }

        public static GroupMembershipRequest getGroupMembershipRequest(string communityId, string requestId)
        {
            return Implementation.getGroupMembershipRequest(communityId, requestId);
        }

        public static GroupMembershipRequests getGroupMembershipRequests(string communityId, string groupId)
        {
            return Implementation.getGroupMembershipRequests(communityId, groupId);
        }

        public static GroupMembershipRequests getGroupMembershipRequests(string communityId, string groupId, GroupMembershipRequestStatus status)
        {
            return Implementation.getGroupMembershipRequests(communityId, groupId, status);
        }

        public static ChatterGroupPage getGroups(string communityId)
        {
            return Implementation.getGroups(communityId);
        }

        public static ChatterGroupPage getGroups(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getGroups(communityId, pageParam, pageSize);
        }

        public static ChatterGroupPage getGroups(string communityId, int pageParam, int pageSize, GroupArchiveStatus archiveStatus)
        {
            return Implementation.getGroups(communityId, pageParam, pageSize, archiveStatus);
        }

        public static GroupMember getMember(string communityId, string membershipId)
        {
            return Implementation.getMember(communityId, membershipId);
        }

        public static GroupMemberPage getMembers(string communityId, string groupId)
        {
            return Implementation.getMembers(communityId, groupId);
        }

        public static GroupMemberPage getMembers(string communityId, string groupId, int pageParam, int pageSize)
        {
            return Implementation.getMembers(communityId, groupId, pageParam, pageSize);
        }

        public static BatchResult[] getMembershipBatch(string communityId, List<string> membershipIds)
        {
            return Implementation.getMembershipBatch(communityId, membershipIds);
        }

        public static GroupChatterSettings getMyChatterSettings(string communityId, string groupId)
        {
            return Implementation.getMyChatterSettings(communityId, groupId);
        }

        public static Photo getPhoto(string communityId, string groupId)
        {
            return Implementation.getPhoto(communityId, groupId);
        }

        public static GroupRecord getRecord(string communityId, string groupRecordId)
        {
            return Implementation.getRecord(communityId, groupRecordId);
        }

        public static GroupRecordPage getRecords(string communityId, string groupId)
        {
            return Implementation.getRecords(communityId, groupId);
        }

        public static GroupRecordPage getRecords(string communityId, string groupId, int pageParam, int pageSize)
        {
            return Implementation.getRecords(communityId, groupId, pageParam, pageSize);
        }

        public static Invitations inviteUsers(string groupId, InviteInput invite)
        {
            return Implementation.inviteUsers(groupId, invite);
        }

        public static Announcement postAnnouncement(string communityId, string groupId, AnnouncementInput announcement)
        {
            return Implementation.postAnnouncement(communityId, groupId, announcement);
        }

        public static void removeRecord(string communityId, string groupRecordId)
        {
            Implementation.removeRecord(communityId, groupRecordId);
        }

        public static GroupMembershipRequest requestGroupMembership(string communityId, string groupId)
        {
            return Implementation.requestGroupMembership(communityId, groupId);
        }

        public static ChatterGroupPage searchGroups(string communityId, string q)
        {
            return Implementation.searchGroups(communityId, q);
        }

        public static ChatterGroupPage searchGroups(string communityId, string q, int pageParam, int pageSize)
        {
            return Implementation.searchGroups(communityId, q, pageParam, pageSize);
        }

        public static ChatterGroupPage searchGroups(string communityId, string q, GroupArchiveStatus archiveStatus, int pageParam, int pageSize)
        {
            return Implementation.searchGroups(communityId, q, archiveStatus, pageParam, pageSize);
        }

        public static BannerPhoto setBannerPhoto(string communityId, string groupId, string fileId, int versionNumber)
        {
            return Implementation.setBannerPhoto(communityId, groupId, fileId, versionNumber);
        }

        public static BannerPhoto setBannerPhoto(string communityId, string groupId, BinaryInput fileUpload)
        {
            return Implementation.setBannerPhoto(communityId, groupId, fileUpload);
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string groupId, BannerPhotoInput bannerPhoto)
        {
            return Implementation.setBannerPhotoWithAttributes(communityId, groupId, bannerPhoto);
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string groupId, BannerPhotoInput bannerPhoto, BinaryInput fileUpload)
        {
            return Implementation.setBannerPhotoWithAttributes(communityId, groupId, bannerPhoto, fileUpload);
        }

        public static Photo setPhoto(string communityId, string groupId, string fileId, int versionNumber)
        {
            return Implementation.setPhoto(communityId, groupId, fileId, versionNumber);
        }

        public static Photo setPhoto(string communityId, string groupId, BinaryInput fileUpload)
        {
            return Implementation.setPhoto(communityId, groupId, fileUpload);
        }

        public static Photo setPhotoWithAttributes(string communityId, string groupId, PhotoInput photo)
        {
            return Implementation.setPhotoWithAttributes(communityId, groupId, photo);
        }

        public static Photo setPhotoWithAttributes(string communityId, string groupId, PhotoInput photo, BinaryInput fileUpload)
        {
            return Implementation.setPhotoWithAttributes(communityId, groupId, photo, fileUpload);
        }

        public static ChatterGroup updateGroup(string communityId, string groupId, ChatterGroupInput groupInput)
        {
            return Implementation.updateGroup(communityId, groupId, groupInput);
        }

        public static ChatterGroup updateGroupMember(string communityId, string membershipId, GroupMembershipType role)
        {
            return Implementation.updateGroupMember(communityId, membershipId, role);
        }

        public static GroupChatterSettings updateMyChatterSettings(string communityId, string groupId, GroupEmailFrequency emailFrequency)
        {
            return Implementation.updateMyChatterSettings(communityId, groupId, emailFrequency);
        }

        public static GroupMembershipRequest updateRequestStatus(string communityId, string requestId, GroupMembershipRequestStatus status)
        {
            return Implementation.updateRequestStatus(communityId, requestId, status);
        }

        public static GroupMembershipRequest updateRequestStatus(string communityId, string requestId, GroupMembershipRequestStatus status, string responseMessage)
        {
            return Implementation.updateRequestStatus(communityId, requestId, status, responseMessage);
        }

        public static void setTestSearchGroups(string communityId, string q, ChatterGroupPage result)
        {
            Implementation.setTestSearchGroups(communityId, q, result);
        }

        public static void setTestSearchGroups(string communityId, string q, int pageParam, int pageSize, ChatterGroupPage result)
        {
            Implementation.setTestSearchGroups(communityId, q, pageParam, pageSize, result);
        }

        public static void setTestSearchGroups(string communityId, string q, GroupArchiveStatus archiveStatus, int pageParam, int pageSize, ChatterGroupPage result)
        {
            Implementation.setTestSearchGroups(communityId, q, archiveStatus, pageParam, pageSize, result);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Subscription follow(string communityId, string groupId, string subjectId)
        {
            return Implementation.follow(communityId, groupId, subjectId);
        }

        public static FollowingPage getFollowings(string communityId, string groupId)
        {
            return Implementation.getFollowings(communityId, groupId);
        }

        public static FollowingPage getFollowings(string communityId, string groupId, int pageParam)
        {
            return Implementation.getFollowings(communityId, groupId, pageParam);
        }

        public static FollowingPage getFollowings(string communityId, string groupId, int pageParam, int pageSize)
        {
            return Implementation.getFollowings(communityId, groupId, pageParam, pageSize);
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType)
        {
            return Implementation.getFollowings(communityId, groupId, filterType);
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType, int pageParam)
        {
            return Implementation.getFollowings(communityId, groupId, filterType, pageParam);
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType, int pageParam, int pageSize)
        {
            return Implementation.getFollowings(communityId, groupId, filterType, pageParam, pageSize);
        }

        public static ChatterGroupPage getGroups(string communityId, GroupArchiveStatus archiveStatus, int pageParam, int pageSize)
        {
            return Implementation.getGroups(communityId, archiveStatus, pageParam, pageSize);
        }
    }
}
