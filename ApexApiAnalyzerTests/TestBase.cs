using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using static System.Math;

namespace ApexApiAnalyzerTests
{
    public class TestBase
    {
        protected void CompareLineByLine(string actual, string expected)
        {
            var actualList = actual.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var expectedList = expected.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < Min(expectedList.Length, actualList.Length); i++)
            {
                Assert.AreEqual(expectedList[i].Trim(), actualList[i].Trim());
            }

            if (Abs(expectedList.Length - actualList.Length) > 1)
            {
                Assert.Fail("Too many difference in lines: expected {0}, actual {1}", expectedList.Length, actualList.Length);
            }
        }

        private Stream GetZipResource(string fileName)
        {
            var assembly = typeof(TestBase).GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream($"{assembly.GetName().Name}.ZipFiles.{fileName}.zip");
        }

        public IEnumerable<string> GetApexClassesFromZipFile(string fileName)
        {
            var file = GetZipResource(fileName);
            var zip = new ZipArchive(file, ZipArchiveMode.Read, false);
            var apexClasses =
                from entry in zip.Entries.OfType<ZipArchiveEntry>()
                where entry.Name.EndsWith(".cls", StringComparison.InvariantCultureIgnoreCase)
                select entry;

            // Process all Apex files, don't stop after the first error
            foreach (var entry in apexClasses)
            {
                using (var stream = entry.Open())
                using (var reader = new StreamReader(stream))
                {
                    var fileContents = reader.ReadToEnd();
                    yield return fileContents;
                }
            }
        }
    }
}
