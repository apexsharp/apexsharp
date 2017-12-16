namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_ChatterMessages_static_methods.htm#apex_ConnectAPI_ChatterMessages_static_methods
    /// </summary>
    public class ChatterMessages
    {
        // infrastructure
        public ChatterMessages(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ChatterMessages));
            }
        }

        // API
        public static ChatterConversation getConversation(string conversationId)
        {
            return Implementation.getConversation(conversationId);
        }

        public static ChatterConversation getConversation(string conversationId, string pageParam, int pageSize)
        {
            return Implementation.getConversation(conversationId, pageParam, pageSize);
        }

        public static ChatterConversation getConversation(string communityId, string conversationId)
        {
            return Implementation.getConversation(communityId, conversationId);
        }

        public static ChatterConversation getConversation(string communityId, string conversationId, string pageParam, string pageSize)
        {
            return Implementation.getConversation(communityId, conversationId, pageParam, pageSize);
        }

        public static ChatterConversationPage getConversations()
        {
            return Implementation.getConversations();
        }

        public static ChatterConversationPage getConversations(string pageParam, int pageSize)
        {
            return Implementation.getConversations(pageParam, pageSize);
        }

        public static ChatterConversationPage getConversations(string communityId)
        {
            return Implementation.getConversations(communityId);
        }

        public static ChatterConversationPage getConversations(string communityId, string pageParam, int pageSize)
        {
            return Implementation.getConversations(communityId, pageParam, pageSize);
        }

        public static ChatterMessage getMessage(string messageId)
        {
            return Implementation.getMessage(messageId);
        }

        public static ChatterMessage getMessage(string communityId, string messageId)
        {
            return Implementation.getMessage(communityId, messageId);
        }

        public static ChatterMessagePage getMessages()
        {
            return Implementation.getMessages();
        }

        public static ChatterMessagePage getMessages(string pageParam, int pageSize)
        {
            return Implementation.getMessages(pageParam, pageSize);
        }

        public static ChatterMessagePage getMessages(string communityId)
        {
            return Implementation.getMessages(communityId);
        }

        public static ChatterMessagePage getMessages(string communityId, string pageParam, int pageSize)
        {
            return Implementation.getMessages(communityId, pageParam, pageSize);
        }

        public static UnreadConversationCount getUnreadCount()
        {
            return Implementation.getUnreadCount();
        }

        public static UnreadConversationCount getUnreadCount(string communityId)
        {
            return Implementation.getUnreadCount(communityId);
        }

        public static ChatterConversationSummary markConversationRead(string conversationId, bool read)
        {
            return Implementation.markConversationRead(conversationId, read);
        }

        public static ChatterConversationSummary markConversationRead(string communityId, string conversationID, bool read)
        {
            return Implementation.markConversationRead(communityId, conversationID, read);
        }

        public static ChatterMessage replyToMessage(string text, string inReplyTo)
        {
            return Implementation.replyToMessage(text, inReplyTo);
        }

        public static ChatterMessage replyToMessage(string communityId, string text, string inReplyTo)
        {
            return Implementation.replyToMessage(communityId, text, inReplyTo);
        }

        public static ChatterConversation searchConversation(string conversationId, string q)
        {
            return Implementation.searchConversation(conversationId, q);
        }

        public static ChatterConversation searchConversation(string conversationId, string pageParam, int pageSize, string q)
        {
            return Implementation.searchConversation(conversationId, pageParam, pageSize, q);
        }

        public static ChatterConversation searchConversation(string communityId, string conversationId, string q)
        {
            return Implementation.searchConversation(communityId, conversationId, q);
        }

        public static ChatterConversation searchConversation(string communityId, string conversationId, string pageParam, int pageSize, string q)
        {
            return Implementation.searchConversation(communityId, conversationId, pageParam, pageSize, q);
        }

        public static ChatterConversationPage searchConversations(string q)
        {
            return Implementation.searchConversations(q);
        }

        public static ChatterConversationPage searchConversations(string pageParam, int pageSize, string q)
        {
            return Implementation.searchConversations(pageParam, pageSize, q);
        }

        public static ChatterConversationPage searchConversations(string communityId, string q)
        {
            return Implementation.searchConversations(communityId, q);
        }

        public static ChatterConversationPage searchConversations(string communityId, string pageParam, int pageSize, string q)
        {
            return Implementation.searchConversations(communityId, pageParam, pageSize, q);
        }

        public static ChatterMessagePage searchMessages(string q)
        {
            return Implementation.searchMessages(q);
        }

        public static ChatterMessagePage searchMessages(string pageParam, int pageSize, string q)
        {
            return Implementation.searchMessages(pageParam, pageSize, q);
        }

        public static ChatterMessagePage searchMessages(string communityId, string q)
        {
            return Implementation.searchMessages(communityId, q);
        }

        public static ChatterMessagePage searchMessages(string communityId, string pageParam, int pageSize, string q)
        {
            return Implementation.searchMessages(communityId, pageParam, pageSize, q);
        }

        public static ChatterMessage sendMessage(string text, string recipients)
        {
            return Implementation.sendMessage(text, recipients);
        }

        public static ChatterMessage sendMessage(string communityId, string text, string recipients)
        {
            return Implementation.sendMessage(communityId, text, recipients);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static ChatterConversation getConversation(string communityId, string conversationId, string pageParam, int pageSize)
        {
            return Implementation.getConversation(communityId, conversationId, pageParam, pageSize);
        }
    }
}
