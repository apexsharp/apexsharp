using Explicit = NUnit.Framework.ExplicitAttribute;

namespace Apex.ApexSharp.NUnit
{
    public class ExplicitAttribute : Explicit
    {
        public ExplicitAttribute()
        {
        }

        public ExplicitAttribute(string reason) : base(reason)
        {
        }
    }
}
