namespace Apex.Site
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_site_urlRewriter_reference.htm#apex_site_urlRewriter_reference
    /// </summary>
    public interface UrlRewriter
    {
        PageReference[] generateUrlFor(PageReference[] salesforceUrls);

        PageReference mapRequestUrl(PageReference userFriendlyUrl);

        List<PageReference> generateUrlFor(List<PageReference> param1);
    }
}
