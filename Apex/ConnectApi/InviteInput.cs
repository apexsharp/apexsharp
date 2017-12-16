namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class InviteInput
    {
        // infrastructure
        public InviteInput(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(InviteInput));
            }
        }

        // API
        object invitees
        {
            get
            {
                return Self.invitees;
            }
            set
            {
                Self.invitees = value;
            }
        }

        object message
        {
            get
            {
                return Self.message;
            }
            set
            {
                Self.message = value;
            }
        }

        public InviteInput()
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
