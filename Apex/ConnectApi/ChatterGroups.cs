using Apex.System;

namespace Apex.ConnectApi
{
    public class ChatterGroups
    {
        public static GroupMember addMember(string communityId, string groupId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.AddMember");
        }

        public static GroupMember addMemberWithRole(string communityId, string groupId, string userId,
            GroupMembershipType role)
        {
            throw new global::System.NotImplementedException("ChatterGroups.AddMemberWithRole");
        }

        public static GroupRecord addRecord(string communityId, string groupId, string recordId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.AddRecord");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("ChatterGroups.Clone");
        }

        public static ChatterGroupDetail createGroup(string communityId, ChatterGroupInput groupInput)
        {
            throw new global::System.NotImplementedException("ChatterGroups.CreateGroup");
        }

        public static void deleteBannerPhoto(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.DeleteBannerPhoto");
        }

        public static void deleteGroup(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.DeleteGroup");
        }

        public static void deleteMember(string communityId, string membershipId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.DeleteMember");
        }

        public static void deletePhoto(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.DeletePhoto");
        }

        public static Subscription follow(string communityId, string groupId, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.Follow");
        }

        public static AnnouncementPage getAnnouncements(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetAnnouncements");
        }

        public static AnnouncementPage getAnnouncements(string communityId, string groupId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetAnnouncements");
        }

        public static BannerPhoto getBannerPhoto(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetBannerPhoto");
        }

        public static FollowingPage getFollowings(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string groupId, int pageParam)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string groupId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType, int pageParam)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string groupId, string filterType, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetFollowings");
        }

        public static ChatterGroupDetail getGroup(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroup");
        }

        public static List<BatchResult> getGroupBatch(string communityId, List<string> groupIds)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroupBatch");
        }

        public static GroupMembershipRequest getGroupMembershipRequest(string communityId, string requestId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroupMembershipRequest");
        }

        public static GroupMembershipRequests getGroupMembershipRequests(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroupMembershipRequests");
        }

        public static GroupMembershipRequests getGroupMembershipRequests(string communityId, string groupId,
            GroupMembershipRequestStatus status)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroupMembershipRequests");
        }

        public static ChatterGroupPage getGroups(string communityId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroups");
        }

        public static ChatterGroupPage getGroups(string communityId, GroupArchiveStatus archiveStatus, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroups");
        }

        public static ChatterGroupPage getGroups(string communityId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetGroups");
        }

        public static GroupMember getMember(string communityId, string membershipId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetMember");
        }

        public static GroupMemberPage getMembers(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetMembers");
        }

        public static GroupMemberPage getMembers(string communityId, string groupId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetMembers");
        }

        public static List<BatchResult> getMembershipBatch(string communityId, List<string> membershipIds)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetMembershipBatch");
        }

        public static GroupChatterSettings getMyChatterSettings(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetMyChatterSettings");
        }

        public static Photo getPhoto(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetPhoto");
        }

        public static GroupRecord getRecord(string communityId, string groupRecordId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetRecord");
        }

        public static GroupRecordPage getRecords(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetRecords");
        }

        public static GroupRecordPage getRecords(string communityId, string groupId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.GetRecords");
        }

        public static Invitations inviteUsers(string groupId, InviteInput invite)
        {
            throw new global::System.NotImplementedException("ChatterGroups.InviteUsers");
        }

        public static Announcement postAnnouncement(string communityId, string groupId, AnnouncementInput announcement)
        {
            throw new global::System.NotImplementedException("ChatterGroups.PostAnnouncement");
        }

        public static void removeRecord(string communityId, string groupRecordId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.RemoveRecord");
        }

        public static GroupMembershipRequest requestGroupMembership(string communityId, string groupId)
        {
            throw new global::System.NotImplementedException("ChatterGroups.RequestGroupMembership");
        }

        public static ChatterGroupPage searchGroups(string communityId, string q)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SearchGroups");
        }

        public static ChatterGroupPage searchGroups(string communityId, string q, GroupArchiveStatus archiveStatus,
            int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SearchGroups");
        }

        public static ChatterGroupPage searchGroups(string communityId, string q, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SearchGroups");
        }

        public static BannerPhoto setBannerPhoto(string communityId, string groupId, BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetBannerPhoto");
        }

        public static BannerPhoto setBannerPhoto(string communityId, string groupId, string fileId, int versionNumber)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetBannerPhoto");
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string groupId,
            BannerPhotoInput bannerPhoto)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetBannerPhotoWithAttributes");
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string groupId,
            BannerPhotoInput bannerPhoto, BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetBannerPhotoWithAttributes");
        }

        public static Photo setPhoto(string communityId, string groupId, BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetPhoto");
        }

        public static Photo setPhoto(string communityId, string groupId, string fileId, int versionNumber)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetPhoto");
        }

        public static Photo setPhotoWithAttributes(string communityId, string groupId, PhotoInput photo)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetPhotoWithAttributes");
        }

        public static Photo setPhotoWithAttributes(string communityId, string groupId, PhotoInput photo,
            BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetPhotoWithAttributes");
        }

        public static void setTestSearchGroups(string communityId, string q, ChatterGroupPage result)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetTestSearchGroups");
        }

        public static void setTestSearchGroups(string communityId, string q, GroupArchiveStatus archiveStatus,
            int pageParam, int pageSize, ChatterGroupPage result)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetTestSearchGroups");
        }

        public static void setTestSearchGroups(string communityId, string q, int pageParam, int pageSize,
            ChatterGroupPage result)
        {
            throw new global::System.NotImplementedException("ChatterGroups.SetTestSearchGroups");
        }

        public static ChatterGroupDetail updateGroup(string communityId, string groupId, ChatterGroupInput groupInput)
        {
            throw new global::System.NotImplementedException("ChatterGroups.UpdateGroup");
        }

        public static GroupMember updateGroupMember(string communityId, string membershipId, GroupMembershipType role)
        {
            throw new global::System.NotImplementedException("ChatterGroups.UpdateGroupMember");
        }

        public static GroupChatterSettings updateMyChatterSettings(string communityId, string groupId,
            GroupEmailFrequency emailFrequency)
        {
            throw new global::System.NotImplementedException("ChatterGroups.UpdateMyChatterSettings");
        }

        public static GroupMembershipRequest updateRequestStatus(string communityId, string requestId,
            GroupMembershipRequestStatus status)
        {
            throw new global::System.NotImplementedException("ChatterGroups.UpdateRequestStatus");
        }

        public static GroupMembershipRequest updateRequestStatus(string communityId, string requestId,
            GroupMembershipRequestStatus status, string responseMessage)
        {
            throw new global::System.NotImplementedException("ChatterGroups.UpdateRequestStatus");
        }
    }
}