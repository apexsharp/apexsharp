using System.IO;
using System.Reflection;

namespace ApexSharpApiTest
{
    public class TestBase
    {
        protected string GetJsonResource(string name)
        {
            var assembly = typeof(ModelGenTests).GetTypeInfo().Assembly;
            var rstream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.JsonSamples.{name}.json");
            using (var streamReader = new StreamReader(rstream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
