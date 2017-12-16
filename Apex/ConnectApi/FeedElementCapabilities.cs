namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedElementCapabilities
    {
        // infrastructure
        public FeedElementCapabilities(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedElementCapabilities));
            }
        }

        // API
        object approval
        {
            get
            {
                return Self.approval;
            }
            set
            {
                Self.approval = value;
            }
        }

        object associatedActions
        {
            get
            {
                return Self.associatedActions;
            }
            set
            {
                Self.associatedActions = value;
            }
        }

        object banner
        {
            get
            {
                return Self.banner;
            }
            set
            {
                Self.banner = value;
            }
        }

        object bookmarks
        {
            get
            {
                return Self.bookmarks;
            }
            set
            {
                Self.bookmarks = value;
            }
        }

        object bundle
        {
            get
            {
                return Self.bundle;
            }
            set
            {
                Self.bundle = value;
            }
        }

        object canvas
        {
            get
            {
                return Self.canvas;
            }
            set
            {
                Self.canvas = value;
            }
        }

        object caseComment
        {
            get
            {
                return Self.caseComment;
            }
            set
            {
                Self.caseComment = value;
            }
        }

        object chatterLikes
        {
            get
            {
                return Self.chatterLikes;
            }
            set
            {
                Self.chatterLikes = value;
            }
        }

        object comments
        {
            get
            {
                return Self.comments;
            }
            set
            {
                Self.comments = value;
            }
        }

        object content
        {
            get
            {
                return Self.content;
            }
            set
            {
                Self.content = value;
            }
        }

        object dashboardComponentSnapshot
        {
            get
            {
                return Self.dashboardComponentSnapshot;
            }
            set
            {
                Self.dashboardComponentSnapshot = value;
            }
        }

        object directMessage
        {
            get
            {
                return Self.directMessage;
            }
            set
            {
                Self.directMessage = value;
            }
        }

        object edit
        {
            get
            {
                return Self.edit;
            }
            set
            {
                Self.edit = value;
            }
        }

        object emailMessage
        {
            get
            {
                return Self.emailMessage;
            }
            set
            {
                Self.emailMessage = value;
            }
        }

        object enhancedLink
        {
            get
            {
                return Self.enhancedLink;
            }
            set
            {
                Self.enhancedLink = value;
            }
        }

        object extensions
        {
            get
            {
                return Self.extensions;
            }
            set
            {
                Self.extensions = value;
            }
        }

        object feedEntityShare
        {
            get
            {
                return Self.feedEntityShare;
            }
            set
            {
                Self.feedEntityShare = value;
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

        object interactions
        {
            get
            {
                return Self.interactions;
            }
            set
            {
                Self.interactions = value;
            }
        }

        object link
        {
            get
            {
                return Self.link;
            }
            set
            {
                Self.link = value;
            }
        }

        object mediaReferences
        {
            get
            {
                return Self.mediaReferences;
            }
            set
            {
                Self.mediaReferences = value;
            }
        }

        object moderation
        {
            get
            {
                return Self.moderation;
            }
            set
            {
                Self.moderation = value;
            }
        }

        object mute
        {
            get
            {
                return Self.mute;
            }
            set
            {
                Self.mute = value;
            }
        }

        object origin
        {
            get
            {
                return Self.origin;
            }
            set
            {
                Self.origin = value;
            }
        }

        object pin
        {
            get
            {
                return Self.pin;
            }
            set
            {
                Self.pin = value;
            }
        }

        object poll
        {
            get
            {
                return Self.poll;
            }
            set
            {
                Self.poll = value;
            }
        }

        object questionAndAnswers
        {
            get
            {
                return Self.questionAndAnswers;
            }
            set
            {
                Self.questionAndAnswers = value;
            }
        }

        object readBy
        {
            get
            {
                return Self.readBy;
            }
            set
            {
                Self.readBy = value;
            }
        }

        object recommendations
        {
            get
            {
                return Self.recommendations;
            }
            set
            {
                Self.recommendations = value;
            }
        }

        object recordSnapshot
        {
            get
            {
                return Self.recordSnapshot;
            }
            set
            {
                Self.recordSnapshot = value;
            }
        }

        object socialPost
        {
            get
            {
                return Self.socialPost;
            }
            set
            {
                Self.socialPost = value;
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

        object topics
        {
            get
            {
                return Self.topics;
            }
            set
            {
                Self.topics = value;
            }
        }

        object trackedChanges
        {
            get
            {
                return Self.trackedChanges;
            }
            set
            {
                Self.trackedChanges = value;
            }
        }

        object upDownVote
        {
            get
            {
                return Self.upDownVote;
            }
            set
            {
                Self.upDownVote = value;
            }
        }

        public FeedElementCapabilities()
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
