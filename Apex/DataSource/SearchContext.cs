namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_SearchContext.htm#apex_class_DataSource_SearchContext
    /// </summary>
    public class SearchContext
    {
        // infrastructure
        public SearchContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SearchContext));
            }
        }

        // API
        public SearchContext(List<Table> metadata, int offset, int maxResults, List<TableSelection> tableSelections, string searchPhrase)
        {
            Self = Implementation.Constructor(metadata, offset, maxResults, tableSelections, searchPhrase);
        }

        public SearchContext()
        {
            Self = Implementation.Constructor();
        }

        string searchPhrase
        {
            get
            {
                return Self.searchPhrase;
            }
            set
            {
                Self.searchPhrase = value;
            }
        }

        List<TableSelection> tableSelections
        {
            get
            {
                return Self.tableSelections;
            }
            set
            {
                Self.tableSelections = value;
            }
        }
    }
}
