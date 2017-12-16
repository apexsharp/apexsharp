namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Features
    {
        // infrastructure
        public Features(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Features));
            }
        }

        // API
        object activityReminderNotificationsEnabled
        {
            get
            {
                return Self.activityReminderNotificationsEnabled;
            }
            set
            {
                Self.activityReminderNotificationsEnabled = value;
            }
        }

        object chatter
        {
            get
            {
                return Self.chatter;
            }
            set
            {
                Self.chatter = value;
            }
        }

        object chatterActivity
        {
            get
            {
                return Self.chatterActivity;
            }
            set
            {
                Self.chatterActivity = value;
            }
        }

        object chatterAnswers
        {
            get
            {
                return Self.chatterAnswers;
            }
            set
            {
                Self.chatterAnswers = value;
            }
        }

        object chatterGlobalInfluence
        {
            get
            {
                return Self.chatterGlobalInfluence;
            }
            set
            {
                Self.chatterGlobalInfluence = value;
            }
        }

        object chatterGroupRecords
        {
            get
            {
                return Self.chatterGroupRecords;
            }
            set
            {
                Self.chatterGroupRecords = value;
            }
        }

        object chatterGroupRecordSharing
        {
            get
            {
                return Self.chatterGroupRecordSharing;
            }
            set
            {
                Self.chatterGroupRecordSharing = value;
            }
        }

        object chatterMessages
        {
            get
            {
                return Self.chatterMessages;
            }
            set
            {
                Self.chatterMessages = value;
            }
        }

        object chatterTopics
        {
            get
            {
                return Self.chatterTopics;
            }
            set
            {
                Self.chatterTopics = value;
            }
        }

        object communitiesEnabled
        {
            get
            {
                return Self.communitiesEnabled;
            }
            set
            {
                Self.communitiesEnabled = value;
            }
        }

        object communityModeration
        {
            get
            {
                return Self.communityModeration;
            }
            set
            {
                Self.communityModeration = value;
            }
        }

        object communityReputation
        {
            get
            {
                return Self.communityReputation;
            }
            set
            {
                Self.communityReputation = value;
            }
        }

        object connectRecords
        {
            get
            {
                return Self.connectRecords;
            }
            set
            {
                Self.connectRecords = value;
            }
        }

        object dashboardComponentSnapshots
        {
            get
            {
                return Self.dashboardComponentSnapshots;
            }
            set
            {
                Self.dashboardComponentSnapshots = value;
            }
        }

        object defaultCurrencyIsoCode
        {
            get
            {
                return Self.defaultCurrencyIsoCode;
            }
            set
            {
                Self.defaultCurrencyIsoCode = value;
            }
        }

        object favoritesEnabled
        {
            get
            {
                return Self.favoritesEnabled;
            }
            set
            {
                Self.favoritesEnabled = value;
            }
        }

        object favoritesLimit
        {
            get
            {
                return Self.favoritesLimit;
            }
            set
            {
                Self.favoritesLimit = value;
            }
        }

        object feedPolling
        {
            get
            {
                return Self.feedPolling;
            }
            set
            {
                Self.feedPolling = value;
            }
        }

        object feedStreamEnabled
        {
            get
            {
                return Self.feedStreamEnabled;
            }
            set
            {
                Self.feedStreamEnabled = value;
            }
        }

        object files
        {
            get
            {
                return Self.files;
            }
            set
            {
                Self.files = value;
            }
        }

        object filesOnComments
        {
            get
            {
                return Self.filesOnComments;
            }
            set
            {
                Self.filesOnComments = value;
            }
        }

        object forecasting3AggregatedEnabled
        {
            get
            {
                return Self.forecasting3AggregatedEnabled;
            }
            set
            {
                Self.forecasting3AggregatedEnabled = value;
            }
        }

        object forecastingEnabled
        {
            get
            {
                return Self.forecastingEnabled;
            }
            set
            {
                Self.forecastingEnabled = value;
            }
        }

        object forecastingPeriodRange
        {
            get
            {
                return Self.forecastingPeriodRange;
            }
            set
            {
                Self.forecastingPeriodRange = value;
            }
        }

        object forecastingPeriodStart
        {
            get
            {
                return Self.forecastingPeriodStart;
            }
            set
            {
                Self.forecastingPeriodStart = value;
            }
        }

        object forecastingPeriodType
        {
            get
            {
                return Self.forecastingPeriodType;
            }
            set
            {
                Self.forecastingPeriodType = value;
            }
        }

        object groupsCanFollow
        {
            get
            {
                return Self.groupsCanFollow;
            }
            set
            {
                Self.groupsCanFollow = value;
            }
        }

        object ideas
        {
            get
            {
                return Self.ideas;
            }
            set
            {
                Self.ideas = value;
            }
        }

        object liveAgentHostName
        {
            get
            {
                return Self.liveAgentHostName;
            }
            set
            {
                Self.liveAgentHostName = value;
            }
        }

        object managedTopicsEnabled
        {
            get
            {
                return Self.managedTopicsEnabled;
            }
            set
            {
                Self.managedTopicsEnabled = value;
            }
        }

        object maxEntitySubscriptionsPerStream
        {
            get
            {
                return Self.maxEntitySubscriptionsPerStream;
            }
            set
            {
                Self.maxEntitySubscriptionsPerStream = value;
            }
        }

        object maxFilesPerFeedItem
        {
            get
            {
                return Self.maxFilesPerFeedItem;
            }
            set
            {
                Self.maxFilesPerFeedItem = value;
            }
        }

        object maxStreamsPerPerson
        {
            get
            {
                return Self.maxStreamsPerPerson;
            }
            set
            {
                Self.maxStreamsPerPerson = value;
            }
        }

        object mobileNotificationsEnabled
        {
            get
            {
                return Self.mobileNotificationsEnabled;
            }
            set
            {
                Self.mobileNotificationsEnabled = value;
            }
        }

        object multiCurrency
        {
            get
            {
                return Self.multiCurrency;
            }
            set
            {
                Self.multiCurrency = value;
            }
        }

        object offlineEditEnabled
        {
            get
            {
                return Self.offlineEditEnabled;
            }
            set
            {
                Self.offlineEditEnabled = value;
            }
        }

        object publisherActions
        {
            get
            {
                return Self.publisherActions;
            }
            set
            {
                Self.publisherActions = value;
            }
        }

        object storeDataOnDevicesEnabled
        {
            get
            {
                return Self.storeDataOnDevicesEnabled;
            }
            set
            {
                Self.storeDataOnDevicesEnabled = value;
            }
        }

        object thanksAllowed
        {
            get
            {
                return Self.thanksAllowed;
            }
            set
            {
                Self.thanksAllowed = value;
            }
        }

        object trendingTopics
        {
            get
            {
                return Self.trendingTopics;
            }
            set
            {
                Self.trendingTopics = value;
            }
        }

        object viralInvitesAllowed
        {
            get
            {
                return Self.viralInvitesAllowed;
            }
            set
            {
                Self.viralInvitesAllowed = value;
            }
        }

        object wave
        {
            get
            {
                return Self.wave;
            }
            set
            {
                Self.wave = value;
            }
        }

        public Features()
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
