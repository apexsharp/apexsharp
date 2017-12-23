namespace Apex.WaveTemplate
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Answers
    {
        // infrastructure
        public Answers(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Answers));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public object get(string name)
        {
            return Self.get(name);
        }

        public void put(string name, object newValue)
        {
            Self.put(name, newValue);
        }
    }
}
