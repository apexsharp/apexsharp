namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class GroupViralInvitationsStatus
    {
        // infrastructure
        public GroupViralInvitationsStatus(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(GroupViralInvitationsStatus));
            }
        }

        // API
        object ActedUponUser
        {
            get
            {
                return Self.ActedUponUser;
            }
            set
            {
                Self.ActedUponUser = value;
            }
        }

        object Invited
        {
            get
            {
                return Self.Invited;
            }
            set
            {
                Self.Invited = value;
            }
        }

        object MaxedOutUsers
        {
            get
            {
                return Self.MaxedOutUsers;
            }
            set
            {
                Self.MaxedOutUsers = value;
            }
        }

        object MultipleError
        {
            get
            {
                return Self.MultipleError;
            }
            set
            {
                Self.MultipleError = value;
            }
        }

        object NoActionNeededUser
        {
            get
            {
                return Self.NoActionNeededUser;
            }
            set
            {
                Self.NoActionNeededUser = value;
            }
        }

        object NotVisibleToExternalInviter
        {
            get
            {
                return Self.NotVisibleToExternalInviter;
            }
            set
            {
                Self.NotVisibleToExternalInviter = value;
            }
        }

        object Unhandled
        {
            get
            {
                return Self.Unhandled;
            }
            set
            {
                Self.Unhandled = value;
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

        public static List<GroupViralInvitationsStatus> values()
        {
            return Implementation.values();
        }
    }
}
