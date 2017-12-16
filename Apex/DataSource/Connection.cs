namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Connection.htm#apex_class_DataSource_Connection
    /// </summary>
    public class Connection
    {
        // infrastructure
        public Connection(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Connection));
            }
        }

        // API
        public List<DeleteResult> deleteRows(DeleteContext deleteContext)
        {
            return Self.deleteRows(deleteContext);
        }

        public TableResult query(QueryContext queryContext)
        {
            return Self.query(queryContext);
        }

        public List<TableResult> search(SearchContext searchContext)
        {
            return Self.search(searchContext);
        }

        public List<Table> sync()
        {
            return Self.sync();
        }

        public List<UpsertResult> upsertRows(UpsertContext upsertContext)
        {
            return Self.upsertRows(upsertContext);
        }
    }
}
