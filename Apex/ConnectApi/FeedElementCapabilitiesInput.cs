namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class FeedElementCapabilitiesInput
    {
        // infrastructure
        public FeedElementCapabilitiesInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FeedElementCapabilitiesInput));
            }
        }

        // API
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

        public FeedElementCapabilitiesInput()
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
