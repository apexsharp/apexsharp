using Ignore = NUnit.Framework.IgnoreAttribute;

namespace Apex.ApexSharp.NUnit
{
    public class IgnoreAttribute : Ignore
    {
        public IgnoreAttribute(string msg = "TODO") : base(msg)
        {
        }
    }
}
