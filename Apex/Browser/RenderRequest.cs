namespace Apex.Browser
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class RenderRequest
    {
        // infrastructure
        public RenderRequest(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(RenderRequest));
            }
        }

        // API
        public RenderRequest()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public string getPageContent()
        {
            return Self.getPageContent();
        }

        public string getPageReadyExpression()
        {
            return Self.getPageReadyExpression();
        }

        public PageReference getPageReference()
        {
            return Self.getPageReference();
        }

        public RenderRequest setPageContent(string pageContent)
        {
            return Self.setPageContent(pageContent);
        }

        public RenderRequest setPageReadyExpression(string pageReadyExpression)
        {
            return Self.setPageReadyExpression(pageReadyExpression);
        }

        public RenderRequest setPageReference(PageReference pageReference)
        {
            return Self.setPageReference(pageReference);
        }
    }
}
