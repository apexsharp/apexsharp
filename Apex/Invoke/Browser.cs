namespace Apex.Invoke
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Browser
    {
        // infrastructure
        public Browser(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Browser));
            }
        }

        // API
        public Browser()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static string invoke(PageReference code, string json)
        {
            return Implementation.invoke(code, json);
        }
    }
}
