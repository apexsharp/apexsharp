namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialNetworkProvider
    {
        // infrastructure
        public SocialNetworkProvider(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialNetworkProvider));
            }
        }

        // API
        object Facebook
        {
            get
            {
                return Self.Facebook;
            }
            set
            {
                Self.Facebook = value;
            }
        }

        object GooglePlus
        {
            get
            {
                return Self.GooglePlus;
            }
            set
            {
                Self.GooglePlus = value;
            }
        }

        object Instagram
        {
            get
            {
                return Self.Instagram;
            }
            set
            {
                Self.Instagram = value;
            }
        }

        object KakaoTalk
        {
            get
            {
                return Self.KakaoTalk;
            }
            set
            {
                Self.KakaoTalk = value;
            }
        }

        object Kik
        {
            get
            {
                return Self.Kik;
            }
            set
            {
                Self.Kik = value;
            }
        }

        object Klout
        {
            get
            {
                return Self.Klout;
            }
            set
            {
                Self.Klout = value;
            }
        }

        object Line
        {
            get
            {
                return Self.Line;
            }
            set
            {
                Self.Line = value;
            }
        }

        object LinkedIn
        {
            get
            {
                return Self.LinkedIn;
            }
            set
            {
                Self.LinkedIn = value;
            }
        }

        object Messenger
        {
            get
            {
                return Self.Messenger;
            }
            set
            {
                Self.Messenger = value;
            }
        }

        object Other
        {
            get
            {
                return Self.Other;
            }
            set
            {
                Self.Other = value;
            }
        }

        object Pinterest
        {
            get
            {
                return Self.Pinterest;
            }
            set
            {
                Self.Pinterest = value;
            }
        }

        object QQ
        {
            get
            {
                return Self.QQ;
            }
            set
            {
                Self.QQ = value;
            }
        }

        object Rypple
        {
            get
            {
                return Self.Rypple;
            }
            set
            {
                Self.Rypple = value;
            }
        }

        object SinaWeibo
        {
            get
            {
                return Self.SinaWeibo;
            }
            set
            {
                Self.SinaWeibo = value;
            }
        }

        object SMS
        {
            get
            {
                return Self.SMS;
            }
            set
            {
                Self.SMS = value;
            }
        }

        object Snapchat
        {
            get
            {
                return Self.Snapchat;
            }
            set
            {
                Self.Snapchat = value;
            }
        }

        object Telegram
        {
            get
            {
                return Self.Telegram;
            }
            set
            {
                Self.Telegram = value;
            }
        }

        object Twitter
        {
            get
            {
                return Self.Twitter;
            }
            set
            {
                Self.Twitter = value;
            }
        }

        object VKontakte
        {
            get
            {
                return Self.VKontakte;
            }
            set
            {
                Self.VKontakte = value;
            }
        }

        object WeChat
        {
            get
            {
                return Self.WeChat;
            }
            set
            {
                Self.WeChat = value;
            }
        }

        object WhatsApp
        {
            get
            {
                return Self.WhatsApp;
            }
            set
            {
                Self.WhatsApp = value;
            }
        }

        object YouTube
        {
            get
            {
                return Self.YouTube;
            }
            set
            {
                Self.YouTube = value;
            }
        }

        public bool equals(object obj)
        {
            return Self.equals(obj);
        }

        public int hashCode()
        {
            return Self.hashCode();
        }

        public int ordinal()
        {
            return Self.ordinal();
        }

        public static List<SocialNetworkProvider> values()
        {
            return Implementation.values();
        }
    }
}
