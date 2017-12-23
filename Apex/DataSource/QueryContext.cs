namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_QueryContext.htm#apex_class_DataSource_QueryContext
    /// </summary>
    public class QueryContext
    {
        // infrastructure
        public QueryContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(QueryContext));
            }
        }

        // API
        string queryMoreToken
        {
            get
            {
                return Self.queryMoreToken;
            }
            set
            {
                Self.queryMoreToken = value;
            }
        }

        TableSelection tableSelection
        {
            get
            {
                return Self.tableSelection;
            }
            set
            {
                Self.tableSelection = value;
            }
        }

        public static QueryContext get(List<Table> metadata, int offset, int maxResults, TableSelection tableSelection)
        {
            return Implementation.get(metadata, offset, maxResults, tableSelection);
        }
    }
}
