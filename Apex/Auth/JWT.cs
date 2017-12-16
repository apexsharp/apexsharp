namespace Apex.Auth
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_Auth_JWT.htm#apex_class_Auth_JWT
    /// </summary>
    public class JWT
    {
        // infrastructure
        public JWT(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(JWT));
            }
        }

        // API
        public object clone()
        {
            return Self.clone();
        }

        public Map<string, object> getAdditionalClaims()
        {
            return Self.getAdditionalClaims();
        }

        public string getAud()
        {
            return Self.getAud();
        }

        public string getIss()
        {
            return Self.getIss();
        }

        public int getNbfClockSkew()
        {
            return Self.getNbfClockSkew();
        }

        public string getSub()
        {
            return Self.getSub();
        }

        public int getValidityLength()
        {
            return Self.getValidityLength();
        }

        public void setAdditionalClaims(Map<string, object> additionalClaims)
        {
            Self.setAdditionalClaims(additionalClaims);
        }

        public void setAud(string aud)
        {
            Self.setAud(aud);
        }

        public void setIss(string iss)
        {
            Self.setIss(iss);
        }

        public void setNbfClockSkew(int nbfClockSkew)
        {
            Self.setNbfClockSkew(nbfClockSkew);
        }

        public void setSub(string sub)
        {
            Self.setSub(sub);
        }

        public void setValidityLength(int validityLength)
        {
            Self.setValidityLength(validityLength);
        }

        public string toJSONString()
        {
            return Self.toJSONString();
        }
    }
}
