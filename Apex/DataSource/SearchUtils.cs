namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_SearchUtils.htm#apex_class_DataSource_SearchUtils
    /// </summary>
    public class SearchUtils
    {
        // infrastructure
        public SearchUtils(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SearchUtils));
            }
        }

        // API
        public static List<TableResult> searchByName(SearchContext searchDetails, Connection connection)
        {
            return Implementation.searchByName(searchDetails, connection);
        }
    }
}
