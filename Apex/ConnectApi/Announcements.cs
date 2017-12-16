namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Announcements_static_methods.htm#apex_ConnectAPI_Annoucements_static_methods
    /// </summary>
    public class Announcements
    {
        // infrastructure
        public Announcements(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Announcements));
            }
        }

        // API
        public static void deleteAnnouncement(string communityId, string announcementId)
        {
            Implementation.deleteAnnouncement(communityId, announcementId);
        }

        public static Announcement getAnnouncement(string communityId, string announcementId)
        {
            return Implementation.getAnnouncement(communityId, announcementId);
        }

        public static AnnouncementPage getAnnouncements(string communityId, string parentId)
        {
            return Implementation.getAnnouncements(communityId, parentId);
        }

        public static AnnouncementPage getAnnouncements(string communityId, string parentId, int pageParam, int pageSize)
        {
            return Implementation.getAnnouncements(communityId, parentId, pageParam, pageSize);
        }

        public static Announcement postAnnouncement(string communityId, AnnouncementInput announcement)
        {
            return Implementation.postAnnouncement(communityId, announcement);
        }

        public static Announcement updateAnnouncement(string communityId, string announcementId, Datetime expirationDate)
        {
            return Implementation.updateAnnouncement(communityId, announcementId, expirationDate);
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
