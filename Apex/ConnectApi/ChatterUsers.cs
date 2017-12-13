using Apex.System;

namespace Apex.ConnectApi
{
    public class ChatterUsers
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("ChatterUsers.Clone");
        }

        public static void deletePhoto(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.DeletePhoto");
        }

        public static Subscription follow(string communityId, string userId, string subjectId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.Follow");
        }

        public static UserChatterSettings getChatterSettings(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetChatterSettings");
        }

        public static FollowerPage getFollowers(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowers");
        }

        public static FollowerPage getFollowers(string communityId, string userId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowers");
        }

        public static FollowingPage getFollowings(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string userId, int pageParam)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string userId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType, int pageParam)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static FollowingPage getFollowings(string communityId, string userId, string filterType, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetFollowings");
        }

        public static UserGroupPage getGroups(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetGroups");
        }

        public static UserGroupPage getGroups(string communityId, string userId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetGroups");
        }

        public static Photo getPhoto(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetPhoto");
        }

        public static Reputation getReputation(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetReputation");
        }

        public static UserDetail getUser(string communityId, string userId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetUser");
        }

        public static List<BatchResult> getUserBatch(string communityId, List<string> userIds)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetUserBatch");
        }

        public static UserPage getUsers(string communityId)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetUsers");
        }

        public static UserPage getUsers(string communityId, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.GetUsers");
        }

        public static UserGroupPage searchUserGroups(string communityId, string userId, string q)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SearchUserGroups");
        }

        public static UserGroupPage searchUserGroups(string communityId, string userId, string q, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SearchUserGroups");
        }

        public static UserPage searchUsers(string communityId, string q)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SearchUsers");
        }

        public static UserPage searchUsers(string communityId, string q, int pageParam, int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SearchUsers");
        }

        public static UserPage searchUsers(string communityId, string q, string searchContextId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SearchUsers");
        }

        public static Photo setPhoto(string communityId, string userId, BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetPhoto");
        }

        public static Photo setPhoto(string communityId, string userId, string fileId, int versionNumber)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetPhoto");
        }

        public static Photo setPhotoWithAttributes(string communityId, string userId, PhotoInput photo)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetPhotoWithAttributes");
        }

        public static Photo setPhotoWithAttributes(string communityId, string userId, PhotoInput photo,
            BinaryInput fileUpload)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetPhotoWithAttributes");
        }

        public static void setTestSearchUsers(string communityId, string q, UserPage result)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetTestSearchUsers");
        }

        public static void setTestSearchUsers(string communityId, string q, int pageParam, int pageSize,
            UserPage result)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetTestSearchUsers");
        }

        public static void setTestSearchUsers(string communityId, string q, string searchContextId, int pageParam,
            int pageSize, UserPage result)
        {
            throw new global::System.NotImplementedException("ChatterUsers.SetTestSearchUsers");
        }

        public static UserChatterSettings updateChatterSettings(string communityId, string userId,
            GroupEmailFrequency defaultGroupEmailFrequency)
        {
            throw new global::System.NotImplementedException("ChatterUsers.UpdateChatterSettings");
        }

        public static UserDetail updateUser(string communityId, string userId, UserInput userInput)
        {
            throw new global::System.NotImplementedException("ChatterUsers.UpdateUser");
        }
    }
}