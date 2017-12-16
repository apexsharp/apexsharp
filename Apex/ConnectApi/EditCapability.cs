namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class EditCapability
    {
        // infrastructure
        public EditCapability(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(EditCapability));
            }
        }

        // API
        object isEditableByMeUrl
        {
            get
            {
                return Self.isEditableByMeUrl;
            }
            set
            {
                Self.isEditableByMeUrl = value;
            }
        }

        object isEditRestricted
        {
            get
            {
                return Self.isEditRestricted;
            }
            set
            {
                Self.isEditRestricted = value;
            }
        }

        object lastEditedBy
        {
            get
            {
                return Self.lastEditedBy;
            }
            set
            {
                Self.lastEditedBy = value;
            }
        }

        object lastEditedDate
        {
            get
            {
                return Self.lastEditedDate;
            }
            set
            {
                Self.lastEditedDate = value;
            }
        }

        object latestRevision
        {
            get
            {
                return Self.latestRevision;
            }
            set
            {
                Self.latestRevision = value;
            }
        }

        object relativeLastEditedDate
        {
            get
            {
                return Self.relativeLastEditedDate;
            }
            set
            {
                Self.relativeLastEditedDate = value;
            }
        }

        public EditCapability()
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
