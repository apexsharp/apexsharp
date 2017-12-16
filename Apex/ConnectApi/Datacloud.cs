namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_ConnectAPI_Datacloud_static_methods.htm#apex_ConnectAPI_Datacloud_static_methods
    /// </summary>
    public class Datacloud
    {
        // infrastructure
        public Datacloud(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Datacloud));
            }
        }

        // API
        public static DatacloudCompanies getCompaniesFromOrder(string orderId, string pageSize, string page)
        {
            return Implementation.getCompaniesFromOrder(orderId, pageSize, page);
        }

        public static DatacloudCompany getCompany(string companyId)
        {
            return Implementation.getCompany(companyId);
        }

        public static DatacloudContact getContact(string contactId)
        {
            return Implementation.getContact(contactId);
        }

        public static DatacloudContacts getContactsFromOrder(string orderId, string page, string pageSize)
        {
            return Implementation.getContactsFromOrder(orderId, page, pageSize);
        }

        public static DatacloudOrder getOrder(string orderId)
        {
            return Implementation.getOrder(orderId);
        }

        public static DatacloudPurchaseUsage getUsage(string userId)
        {
            return Implementation.getUsage(userId);
        }

        public static DatacloudOrder postOrder(DatacloudOrderInput orderInput)
        {
            return Implementation.postOrder(orderInput);
        }

        public object clone()
        {
            return Self.clone();
        }

        public static DatacloudCompanies getCompaniesFromOrder(string orderId)
        {
            return Implementation.getCompaniesFromOrder(orderId);
        }

        public static DatacloudCompanies getCompaniesFromOrder(string orderId, int pageParam, int pageSize)
        {
            return Implementation.getCompaniesFromOrder(orderId, pageParam, pageSize);
        }

        public static DatacloudContacts getContactsFromOrder(string orderId)
        {
            return Implementation.getContactsFromOrder(orderId);
        }

        public static DatacloudContacts getContactsFromOrder(string orderId, int pageParam, int pageSize)
        {
            return Implementation.getContactsFromOrder(orderId, pageParam, pageSize);
        }
    }
}
