using Test = NUnit.Framework.TestAttribute;

namespace Apex.ApexSharp.NUnit
{
    public class TestAttribute : Test
    {
        public TestAttribute()
        {
        }

        public bool SeeAllData { get; set; }
    }
}
