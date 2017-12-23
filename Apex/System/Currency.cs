namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Currency
    {
        // infrastructure
        public Currency(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Currency));
            }
        }

        // API
        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }

        public string format()
        {
            return Self.format();
        }

        public string formatAmount()
        {
            return Self.formatAmount();
        }

        public static Currency newInstance(decimal amount, string isoCode)
        {
            return Implementation.newInstance(amount, isoCode);
        }
    }
}
