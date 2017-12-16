namespace Apex.Sfc
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Sfc_ContentDownloadHandler.htm#apex_class_Sfc_ContentDownloadHandler
    /// </summary>
    public class ContentDownloadHandler
    {
        // infrastructure
        public ContentDownloadHandler(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ContentDownloadHandler));
            }
        }

        // API
        string downloadErrorMessage
        {
            get
            {
                return Self.downloadErrorMessage;
            }
            set
            {
                Self.downloadErrorMessage = value;
            }
        }

        bool isDownloadAllowed
        {
            get
            {
                return Self.isDownloadAllowed;
            }
            set
            {
                Self.isDownloadAllowed = value;
            }
        }

        string redirectUrl
        {
            get
            {
                return Self.redirectUrl;
            }
            set
            {
                Self.redirectUrl = value;
            }
        }
    }
}
