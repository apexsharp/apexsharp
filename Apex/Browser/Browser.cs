namespace Apex.Browser
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class Browser
    {
        // infrastructure
        public Browser(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Browser));
            }
        }

        // API
        public Browser()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static Blob renderToHtml(RenderRequest renderRequest)
        {
            return Implementation.renderToHtml(renderRequest);
        }

        public static Blob renderToPdf(RenderRequest renderRequest)
        {
            return Implementation.renderToPdf(renderRequest);
        }
    }
}
