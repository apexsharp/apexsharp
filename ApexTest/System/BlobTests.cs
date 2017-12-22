using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class BlobTests
    {
        [Test]
        public void BlobToStringRoundtrip()
        {
            Assert.DoesNotThrow(() =>
            {
                var blob = Blob.valueOf("Hello");
                Assert.NotNull(blob);
                Assert.AreEqual(5, blob.size());

                var str = blob.toString();
                Assert.AreEqual("Hello", str);

                blob = Blob.toPdf("pdf?");
                Assert.NotNull(blob);
                Assert.AreEqual(4, blob.size());

                str = blob.toString();
                Assert.AreEqual("pdf?", str);
            });
        }

        [Test]
        public void BlobToStringRoundtripUsingUnicodeCharacters()
        {
            Assert.DoesNotThrow(() =>
            {
                var unicode = "Людвиг Ван Биткоин";
                var blob = Blob.valueOf(unicode);
                Assert.NotNull(blob);
                Assert.True(blob.size() > unicode.length());

                var str = blob.toString();
                Assert.AreEqual(unicode, str);
            });
        }
    }
}
