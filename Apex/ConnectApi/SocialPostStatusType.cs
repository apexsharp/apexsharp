namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SocialPostStatusType
    {
        // infrastructure
        public SocialPostStatusType(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SocialPostStatusType));
            }
        }

        // API
        object ApprovalPending
        {
            get
            {
                return Self.ApprovalPending;
            }
            set
            {
                Self.ApprovalPending = value;
            }
        }

        object ApprovalRecalled
        {
            get
            {
                return Self.ApprovalRecalled;
            }
            set
            {
                Self.ApprovalRecalled = value;
            }
        }

        object ApprovalRejected
        {
            get
            {
                return Self.ApprovalRejected;
            }
            set
            {
                Self.ApprovalRejected = value;
            }
        }

        object Deleted
        {
            get
            {
                return Self.Deleted;
            }
            set
            {
                Self.Deleted = value;
            }
        }

        object Failed
        {
            get
            {
                return Self.Failed;
            }
            set
            {
                Self.Failed = value;
            }
        }

        object Hidden
        {
            get
            {
                return Self.Hidden;
            }
            set
            {
                Self.Hidden = value;
            }
        }

        object Pending
        {
            get
            {
                return Self.Pending;
            }
            set
            {
                Self.Pending = value;
            }
        }

        object Replied
        {
            get
            {
                return Self.Replied;
            }
            set
            {
                Self.Replied = value;
            }
        }

        object Sent
        {
            get
            {
                return Self.Sent;
            }
            set
            {
                Self.Sent = value;
            }
        }

        object Unknown
        {
            get
            {
                return Self.Unknown;
            }
            set
            {
                Self.Unknown = value;
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

        public static List<SocialPostStatusType> values()
        {
            return Implementation.values();
        }
    }
}
