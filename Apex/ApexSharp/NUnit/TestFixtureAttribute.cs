using TestFixture = NUnit.Framework.TestFixtureAttribute;

namespace Apex.ApexSharp.NUnit
{
    public class TestFixtureAttribute : TestFixture
    {
        public TestFixtureAttribute()
        {
        }

        public bool SeeAllData { get; set; }
    }
}
