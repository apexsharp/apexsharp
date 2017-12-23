namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_UserProfiles_static_methods.htm#apex_ConnectAPI_UserProfiles_static_methods
    /// </summary>
    public class UserProfiles
    {
        // infrastructure
        public UserProfiles(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UserProfiles));
            }
        }

        // API
        public static void deleteBannerPhoto(string communityId, string userId)
        {
            Implementation.deleteBannerPhoto(communityId, userId);
        }

        public static void deletePhoto(string communityId, string userId)
        {
            Implementation.deletePhoto(communityId, userId);
        }

        public static BannerPhoto getBannerPhoto(string communityId, string userId)
        {
            return Implementation.getBannerPhoto(communityId, userId);
        }

        public static Photo getPhoto(string communityId, string userId)
        {
            return Implementation.getPhoto(communityId, userId);
        }

        public static UserProfile getUserProfile(string communityId, string userId)
        {
            return Implementation.getUserProfile(communityId, userId);
        }

        public static BannerPhoto setBannerPhoto(string communityId, string userId, string fileId, int versionNumber)
        {
            return Implementation.setBannerPhoto(communityId, userId, fileId, versionNumber);
        }

        public static BannerPhoto setBannerPhoto(string communityId, string userId, BinaryInput fileUpload)
        {
            return Implementation.setBannerPhoto(communityId, userId, fileUpload);
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string userId, BannerPhotoInput bannerPhoto)
        {
            return Implementation.setBannerPhotoWithAttributes(communityId, userId, bannerPhoto);
        }

        public static BannerPhoto setBannerPhotoWithAttributes(string communityId, string userId, BannerPhotoInput bannerPhoto, BinaryInput fileUpload)
        {
            return Implementation.setBannerPhotoWithAttributes(communityId, userId, bannerPhoto, fileUpload);
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

        public object clone()
        {
            return Self.clone();
        }
    }
}
