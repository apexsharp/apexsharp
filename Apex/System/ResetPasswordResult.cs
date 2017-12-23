namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_ResetPasswordResult.htm#apex_class_System_ResetPasswordResult
    /// </summary>
    public class ResetPasswordResult
    {
        // infrastructure
        public ResetPasswordResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(ResetPasswordResult));
            }
        }

        // API
        public string getPassword()
        {
            return Self.getPassword();
        }

        string password
        {
            get
            {
                return Self.password;
            }
            set
            {
                Self.password = value;
            }
        }
    }
}
