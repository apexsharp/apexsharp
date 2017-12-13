namespace Apex.System
{
    public class Crypto
    {
        public Crypto()
        {
            throw new global::System.NotImplementedException("Crypto");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("Crypto.Clone");
        }

        public static Blob decrypt(string algorithmName, Blob secretKey, Blob initializationVector, Blob encryptedData)
        {
            throw new global::System.NotImplementedException("Crypto.Decrypt");
        }

        public static Blob decryptWithManagedIV(string algorithmName, Blob secretKey, Blob encryptedData)
        {
            throw new global::System.NotImplementedException("Crypto.DecryptWithManagedIV");
        }

        public static Blob encrypt(string algorithmName, Blob secretKey, Blob initializationVector, Blob clearData)
        {
            throw new global::System.NotImplementedException("Crypto.Encrypt");
        }

        public static Blob encryptWithManagedIV(string algorithmName, Blob secretKey, Blob clearData)
        {
            throw new global::System.NotImplementedException("Crypto.EncryptWithManagedIV");
        }

        public static Blob generateAesKey(int size)
        {
            throw new global::System.NotImplementedException("Crypto.GenerateAesKey");
        }

        public static Blob generateDigest(string algorithmName, Blob input)
        {
            throw new global::System.NotImplementedException("Crypto.GenerateDigest");
        }

        public static Blob generateMac(string algorithmName, Blob input, Blob privateKey)
        {
            throw new global::System.NotImplementedException("Crypto.GenerateMac");
        }

        public static int getRandomInteger()
        {
            throw new global::System.NotImplementedException("Crypto.GetRandomInteger");
        }

        public static long getRandomLong()
        {
            throw new global::System.NotImplementedException("Crypto.GetRandomLong");
        }

        public static Blob sign(string algorithmName, Blob input, Blob privateKey)
        {
            throw new global::System.NotImplementedException("Crypto.Sign");
        }

        public static Blob signWithCertificate(string algorithmName, Blob input, string certDevName)
        {
            throw new global::System.NotImplementedException("Crypto.SignWithCertificate");
        }

        public static void signXml(string algorithmName, Dom.XmlNode node, string idAttributeName, string certDevName)
        {
            throw new global::System.NotImplementedException("Crypto.SignXml");
        }

        public static void signXml(string algorithmName, Dom.XmlNode node, string idAttributeName, string certDevName,
            Dom.XmlNode refChild)
        {
            throw new global::System.NotImplementedException("Crypto.SignXml");
        }
    }
}