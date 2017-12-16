namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ChatterUsers_static_methods.htm#apex_ConnectAPI_ChatterUsers_static_methods
    /// </summary>
    public class ChatterUsers
    {
        // infrastructure
        public ChatterUsers(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterUsers));
            }
        }

        // API
        public static void deletePhoto(string communityId, string userId)
        {
            Implementation.deletePhoto(communityId, userId);
        }

        public static Subscription follow(string communityId, string userId, string subjectId)
        {
            return Implementation.follow(communityId, userId, subjectId);
        }

        public static UserChatterSettings getChatterSettings(string communityId, string userId)
        {
            return Implementation.getChatterSettings(communityId, userId);
        }

        public static FollowerPage getFollowers(string communityId, string userId)
        {
            return Implementation.getFollowers(communityId, userId);
        }

        public static FollowerPage getFollowers(string communityId, string userId, int pageParam, int pageSize)
        {
            return Implementation.getFollowers(communityId, userId, pageParam, pageSize);
        }

        public static FollowingPage getFollowings(string communityId, string userId)
        {
            return Implementation.getFollowings(communityId, userId);
        }

        public static FollowingPage getFollowings(string communityId, string userId, int pageParam)
        {
            return Implementation.getFollowings(communityId, userId, pageParam);
        }

        public static FollowingPage getFollowings(string communityId, string userId, int pageParam, int pageSize)
        {
            return Implementation.getFollowings(communityId, userId, pageParam, pageSize);
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType)
        {
            return Implementation.getFollowings(communityId, userId, filterType);
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType, int pageParam)
        {
            return Implementation.getFollowings(communityId, userId, filterType, pageParam);
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType, int pageParam, int pageSize)
        {
            return Implementation.getFollowings(communityId, userId, filterType, pageParam, pageSize);
        }

        public static UserGroupPage getGroups(string communityId, string userId)
        {
            return Implementation.getGroups(communityId, userId);
        }

        public static UserGroupPage getGroups(string communityId, string userId, int pageParam, int pageSize)
        {
            return Implementation.getGroups(communityId, userId, pageParam, pageSize);
        }

        public static Photo getPhoto(string communityId, string userId)
        {
            return Implementation.getPhoto(communityId, userId);
        }

        public static Reputation getReputation(string communityId, string userId)
        {
            return Implementation.getReputation(communityId, userId);
        }

        public static UserSummary getUser(string communityId, string userId)
        {
            return Implementation.getUser(communityId, userId);
        }

        public static BatchResult[] getUserBatch(string communityId, List<string> userIds)
        {
            return Implementation.getUserBatch(communityId, userIds);
        }

        public static UserPage getUsers(string communityId)
        {
            return Implementation.getUsers(communityId);
        }

        public static UserPage getUsers(string communityId, int pageParam, int pageSize)
        {
            return Implementation.getUsers(communityId, pageParam, pageSize);
        }

        public static UserGroupPage searchUserGroups(string communityId, string userId, string q)
        {
            return Implementation.searchUserGroups(communityId, userId, q);
        }

        public static UserGroupPage searchUserGroups(string communityId, string userId, string q, int pageParam, int pageSize)
        {
            return Implementation.searchUserGroups(communityId, userId, q, pageParam, pageSize);
        }

        public static UserPage searchUsers(string communityId, string q)
        {
            return Implementation.searchUsers(communityId, q);
        }

        public static UserPage searchUsers(string communityId, string q, int pageParam, int pageSize)
        {
            return Implementation.searchUsers(communityId, q, pageParam, pageSize);
        }

        public static UserPage searchUsers(string communityId, string q, string searchContextId, int pageParam, int pageSize)
        {
            return Implementation.searchUsers(communityId, q, searchContextId, pageParam, pageSize);
        }

        public static Photo setPhoto(string communityId, string userId, string fileId, int versionNumber)
        {
            return Implementation.setPhoto(communityId, userId, fileId, versionNumber);
        }

        public static Photo setPhoto(string communityId, string userId, BinaryInput fileUpload)
        {
            return Implementation.setPhoto(communityId, userId, fileUpload);
        }

        public static Photo setPhotoWithAttributes(string communityId, string userId, PhotoInput photo)
        {
            return Implementation.setPhotoWithAttributes(communityId, userId, photo);
        }

        public static Photo setPhotoWithAttributes(string communityId, string userId, PhotoInput photo, BinaryInput fileUpload)
        {
            return Implementation.setPhotoWithAttributes(communityId, userId, photo, fileUpload);
        }

        public static UserChatterSettings updateChatterSettings(string communityId, string userId, GroupEmailFrequency defaultGroupEmailFrequency)
        {
            return Implementation.updateChatterSettings(communityId, userId, defaultGroupEmailFrequency);
        }

        public static UserDetail updateUser(string communityId, string userId, UserInput userInput)
        {
            return Implementation.updateUser(communityId, userId, userInput);
        }

        public static void setTestSearchUsers(string communityId, string q, UserPage result)
        {
            Implementation.setTestSearchUsers(communityId, q, result);
        }

        public static void setTestSearchUsers(string communityId, string q, int pageParam, int pageSize, UserPage result)
        {
            Implementation.setTestSearchUsers(communityId, q, pageParam, pageSize, result);
        }

        public static void setTestSearchUsers(string communityId, string q, string searchContextId, int pageParam, int pageSize, UserPage result)
        {
            Implementation.setTestSearchUsers(communityId, q, searchContextId, pageParam, pageSize, result);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
