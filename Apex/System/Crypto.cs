namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;
    using XmlNode = global::System.Object;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_classes_restful_crypto.htm#apex_classes_restful_crypto
    /// </summary>
    public class Crypto
    {
        // infrastructure
        public Crypto(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Crypto));
            }
        }

        // API
        public static Blob decrypt(string algorithmName, Blob privateKey, Blob initializationVector, Blob cipherText)
        {
            return Implementation.decrypt(algorithmName, privateKey, initializationVector, cipherText);
        }

        public static Blob decryptWithManagedIV(string algorithmName, Blob privateKey, Blob IVAndCipherText)
        {
            return Implementation.decryptWithManagedIV(algorithmName, privateKey, IVAndCipherText);
        }

        public static Blob encrypt(string algorithmName, Blob privateKey, Blob initializationVector, Blob clearText)
        {
            return Implementation.encrypt(algorithmName, privateKey, initializationVector, clearText);
        }

        public static Blob encryptWithManagedIV(string algorithmName, Blob privateKey, Blob clearText)
        {
            return Implementation.encryptWithManagedIV(algorithmName, privateKey, clearText);
        }

        public static Blob generateDigest(string algorithmName, Blob input)
        {
            return Implementation.generateDigest(algorithmName, input);
        }

        public static Blob generateMac(string algorithmName, Blob input, Blob privateKey)
        {
            return Implementation.generateMac(algorithmName, input, privateKey);
        }

        public static int getRandomInteger()
        {
            return Implementation.getRandomInteger();
        }

        public static long getRandomLong()
        {
            return Implementation.getRandomLong();
        }

        public static Blob sign(string algorithmName, Blob input, Blob privateKey)
        {
            return Implementation.sign(algorithmName, input, privateKey);
        }

        public static Blob signWithCertificate(string algorithmName, Blob input, string certDevName)
        {
            return Implementation.signWithCertificate(algorithmName, input, certDevName);
        }

        public void signXML(string algorithmName, XmlNode node, string idAttributeName, string certDevName)
        {
            Self.signXML(algorithmName, node, idAttributeName, certDevName);
        }

        public static void signXml(string algorithmName, XmlNode node, string idAttributeName, string certDevName, XmlNode refChild)
        {
            Implementation.signXml(algorithmName, node, idAttributeName, certDevName, refChild);
        }

        public Crypto()
        {
            Self = Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Blob generateAesKey(int size)
        {
            return Implementation.generateAesKey(size);
        }

        public static void signXml(string algorithmName, XmlNode node, string idAttributeName, string certDevName)
        {
            Implementation.signXml(algorithmName, node, idAttributeName, certDevName);
        }
    }
}
