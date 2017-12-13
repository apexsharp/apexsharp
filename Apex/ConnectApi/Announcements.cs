using Apex.System;

namespace Apex.ConnectApi
{
    public class Announcements
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("Announcements.Clone");
        }

        public static void deleteAnnouncement(string communityId, string announcementId)
        {
            throw new global::System.NotImplementedException("Announcements.DeleteAnnouncement");
        }

        public static Announcement getAnnouncement(string communityId, string announcementId)
        {
            throw new global::System.NotImplementedException("Announcements.GetAnnouncement");
        }

        public static AnnouncementPage getAnnouncements(string communityId, string parentId)
        {
            throw new global::System.NotImplementedException("Announcements.GetAnnouncements");
        }

        public static AnnouncementPage getAnnouncements(string communityId, string parentId, int pageParam,
            int pageSize)
        {
            throw new global::System.NotImplementedException("Announcements.GetAnnouncements");
        }

        public static Announcement postAnnouncement(string communityId, AnnouncementInput announcement)
        {
            throw new global::System.NotImplementedException("Announcements.PostAnnouncement");
        }

        public static Announcement updateAnnouncement(string communityId, string announcementId,
            DateTime expirationDate)
        {
            throw new global::System.NotImplementedException("Announcements.UpdateAnnouncement");
        }
    }
}