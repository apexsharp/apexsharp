namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class PageReference
    {
        // infrastructure
        public PageReference(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(PageReference));
            }
        }

        // API
        public PageReference(SObject sobject)
        {
            Self = Implementation.Constructor(sobject);
        }

        public PageReference(string url)
        {
            Self = Implementation.Constructor(url);
        }

        public static PageReference forResource(string resourceName)
        {
            return Implementation.forResource(resourceName);
        }

        public static PageReference forResource(string resourceName, string path)
        {
            return Implementation.forResource(resourceName, path);
        }

        public string getAnchor()
        {
            return Self.getAnchor();
        }

        public Blob getContent()
        {
            return Self.getContent();
        }

        public Blob getContentAsPDF()
        {
            return Self.getContentAsPDF();
        }

        public Map<string, Cookie> getCookies()
        {
            return Self.getCookies();
        }

        public Map<string, string> getHeaders()
        {
            return Self.getHeaders();
        }

        public Map<string, string> getParameters()
        {
            return Self.getParameters();
        }

        public bool getRedirect()
        {
            return Self.getRedirect();
        }

        public string getUrl()
        {
            return Self.getUrl();
        }

        public PageReference setAnchor(string anchor)
        {
            return Self.setAnchor(anchor);
        }

        public void setCookies(List<Cookie> cookies)
        {
            Self.setCookies(cookies);
        }

        public PageReference setRedirect(bool redirect)
        {
            return Self.setRedirect(redirect);
        }
    }
}
