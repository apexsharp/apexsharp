namespace ApexSharpApi.Model.RestApi
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/",
        IsNullable = false)]
    public partial class Envelope
    {
        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get { return this.bodyField; }
            set { this.bodyField = value; }
        }
    }

    public partial class EnvelopeBody
    {
        private loginResponse loginResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:enterprise.soap.sforce.com")]
        public loginResponse loginResponse
        {
            get { return this.loginResponseField; }
            set { this.loginResponseField = value; }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:enterprise.soap.sforce.com", IsNullable = false)]
    public partial class loginResponse
    {
        private loginResponseResult resultField;

        /// <remarks/>
        public loginResponseResult result
        {
            get { return this.resultField; }
            set { this.resultField = value; }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
    public partial class loginResponseResult
    {
        private string metadataServerUrlField;

        private bool passwordExpiredField;

        private bool sandboxField;

        private string serverUrlField;

        private string sessionIdField;

        private string userIdField;

        private loginResponseResultUserInfo userInfoField;

        /// <remarks/>
        public string metadataServerUrl
        {
            get { return this.metadataServerUrlField; }
            set { this.metadataServerUrlField = value; }
        }

        /// <remarks/>
        public bool passwordExpired
        {
            get { return this.passwordExpiredField; }
            set { this.passwordExpiredField = value; }
        }

        /// <remarks/>
        public bool sandbox
        {
            get { return this.sandboxField; }
            set { this.sandboxField = value; }
        }

        /// <remarks/>
        public string serverUrl
        {
            get { return this.serverUrlField; }
            set { this.serverUrlField = value; }
        }

        /// <remarks/>
        public string sessionId
        {
            get { return this.sessionIdField; }
            set { this.sessionIdField = value; }
        }

        /// <remarks/>
        public string userId
        {
            get { return this.userIdField; }
            set { this.userIdField = value; }
        }

        /// <remarks/>
        public loginResponseResultUserInfo userInfo
        {
            get { return this.userInfoField; }
            set { this.userInfoField = value; }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:enterprise.soap.sforce.com")]
    public partial class loginResponseResultUserInfo
    {
        private bool accessibilityModeField;

        private string currencySymbolField;

        private string organizationIdField;

        private bool organizationMultiCurrencyField;

        private string organizationNameField;

        private uint orgAttachmentFileSizeLimitField;

        private string orgDefaultCurrencyIsoCodeField;

        private string orgDefaultCurrencyLocaleField;

        private bool orgDisallowHtmlAttachmentsField;

        private bool orgHasPersonAccountsField;

        private string profileIdField;

        private object roleIdField;

        private ushort sessionSecondsValidField;

        private object userDefaultCurrencyIsoCodeField;

        private string userEmailField;

        private string userFullNameField;

        private string userIdField;

        private string userLanguageField;

        private string userLocaleField;

        private string userNameField;

        private string userTimeZoneField;

        private string userTypeField;

        private string userUiSkinField;

        /// <remarks/>
        public bool accessibilityMode
        {
            get { return this.accessibilityModeField; }
            set { this.accessibilityModeField = value; }
        }

        /// <remarks/>
        public string currencySymbol
        {
            get { return this.currencySymbolField; }
            set { this.currencySymbolField = value; }
        }

        /// <remarks/>
        public uint orgAttachmentFileSizeLimit
        {
            get { return this.orgAttachmentFileSizeLimitField; }
            set { this.orgAttachmentFileSizeLimitField = value; }
        }

        /// <remarks/>
        public string orgDefaultCurrencyIsoCode
        {
            get { return this.orgDefaultCurrencyIsoCodeField; }
            set { this.orgDefaultCurrencyIsoCodeField = value; }
        }

        /// <remarks/>
        public string orgDefaultCurrencyLocale
        {
            get { return this.orgDefaultCurrencyLocaleField; }
            set { this.orgDefaultCurrencyLocaleField = value; }
        }

        /// <remarks/>
        public bool orgDisallowHtmlAttachments
        {
            get { return this.orgDisallowHtmlAttachmentsField; }
            set { this.orgDisallowHtmlAttachmentsField = value; }
        }

        /// <remarks/>
        public bool orgHasPersonAccounts
        {
            get { return this.orgHasPersonAccountsField; }
            set { this.orgHasPersonAccountsField = value; }
        }

        /// <remarks/>
        public string organizationId
        {
            get { return this.organizationIdField; }
            set { this.organizationIdField = value; }
        }

        /// <remarks/>
        public bool organizationMultiCurrency
        {
            get { return this.organizationMultiCurrencyField; }
            set { this.organizationMultiCurrencyField = value; }
        }

        /// <remarks/>
        public string organizationName
        {
            get { return this.organizationNameField; }
            set { this.organizationNameField = value; }
        }

        /// <remarks/>
        public string profileId
        {
            get { return this.profileIdField; }
            set { this.profileIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object roleId
        {
            get { return this.roleIdField; }
            set { this.roleIdField = value; }
        }

        /// <remarks/>
        public ushort sessionSecondsValid
        {
            get { return this.sessionSecondsValidField; }
            set { this.sessionSecondsValidField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object userDefaultCurrencyIsoCode
        {
            get { return this.userDefaultCurrencyIsoCodeField; }
            set { this.userDefaultCurrencyIsoCodeField = value; }
        }

        /// <remarks/>
        public string userEmail
        {
            get { return this.userEmailField; }
            set { this.userEmailField = value; }
        }

        /// <remarks/>
        public string userFullName
        {
            get { return this.userFullNameField; }
            set { this.userFullNameField = value; }
        }

        /// <remarks/>
        public string userId
        {
            get { return this.userIdField; }
            set { this.userIdField = value; }
        }

        /// <remarks/>
        public string userLanguage
        {
            get { return this.userLanguageField; }
            set { this.userLanguageField = value; }
        }

        /// <remarks/>
        public string userLocale
        {
            get { return this.userLocaleField; }
            set { this.userLocaleField = value; }
        }

        /// <remarks/>
        public string userName
        {
            get { return this.userNameField; }
            set { this.userNameField = value; }
        }

        /// <remarks/>
        public string userTimeZone
        {
            get { return this.userTimeZoneField; }
            set { this.userTimeZoneField = value; }
        }

        /// <remarks/>
        public string userType
        {
            get { return this.userTypeField; }
            set { this.userTypeField = value; }
        }

        /// <remarks/>
        public string userUiSkin
        {
            get { return this.userUiSkinField; }
            set { this.userUiSkinField = value; }
        }
    }
}