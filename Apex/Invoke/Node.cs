namespace Apex.Invoke
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Node
    {
        // infrastructure
        public Node(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Node));
            }
        }

        // API
        public Node()
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
