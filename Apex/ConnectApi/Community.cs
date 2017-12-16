namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Community
    {
        // infrastructure
        public Community(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Community));
            }
        }

        // API
        object allowChatterAccessWithoutLogin
        {
            get
            {
                return Self.allowChatterAccessWithoutLogin;
            }
            set
            {
                Self.allowChatterAccessWithoutLogin = value;
            }
        }

        object allowMembersToFlag
        {
            get
            {
                return Self.allowMembersToFlag;
            }
            set
            {
                Self.allowMembersToFlag = value;
            }
        }

        object description
        {
            get
            {
                return Self.description;
            }
            set
            {
                Self.description = value;
            }
        }

        object id
        {
            get
            {
                return Self.id;
            }
            set
            {
                Self.id = value;
            }
        }

        object invitationsEnabled
        {
            get
            {
                return Self.invitationsEnabled;
            }
            set
            {
                Self.invitationsEnabled = value;
            }
        }

        object knowledgeableEnabled
        {
            get
            {
                return Self.knowledgeableEnabled;
            }
            set
            {
                Self.knowledgeableEnabled = value;
            }
        }

        object loginUrl
        {
            get
            {
                return Self.loginUrl;
            }
            set
            {
                Self.loginUrl = value;
            }
        }

        object name
        {
            get
            {
                return Self.name;
            }
            set
            {
                Self.name = value;
            }
        }

        object nicknameDisplayEnabled
        {
            get
            {
                return Self.nicknameDisplayEnabled;
            }
            set
            {
                Self.nicknameDisplayEnabled = value;
            }
        }

        object privateMessagesEnabled
        {
            get
            {
                return Self.privateMessagesEnabled;
            }
            set
            {
                Self.privateMessagesEnabled = value;
            }
        }

        object reputationEnabled
        {
            get
            {
                return Self.reputationEnabled;
            }
            set
            {
                Self.reputationEnabled = value;
            }
        }

        object sendWelcomeEmail
        {
            get
            {
                return Self.sendWelcomeEmail;
            }
            set
            {
                Self.sendWelcomeEmail = value;
            }
        }

        object siteAsContainerEnabled
        {
            get
            {
                return Self.siteAsContainerEnabled;
            }
            set
            {
                Self.siteAsContainerEnabled = value;
            }
        }

        object siteUrl
        {
            get
            {
                return Self.siteUrl;
            }
            set
            {
                Self.siteUrl = value;
            }
        }

        object status
        {
            get
            {
                return Self.status;
            }
            set
            {
                Self.status = value;
            }
        }

        object url
        {
            get
            {
                return Self.url;
            }
            set
            {
                Self.url = value;
            }
        }

        object urlPathPrefix
        {
            get
            {
                return Self.urlPathPrefix;
            }
            set
            {
                Self.urlPathPrefix = value;
            }
        }

        public Community()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public double getBuildVersion()
        {
            return Self.getBuildVersion();
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public string toString()
        {
            return Self.toString();
        }
    }
}
