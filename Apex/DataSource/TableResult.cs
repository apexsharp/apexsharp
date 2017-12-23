namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_TableResult.htm#apex_class_DataSource_TableResult
    /// </summary>
    public class TableResult
    {
        // infrastructure
        public TableResult(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(TableResult));
            }
        }

        // API
        string errorMessage
        {
            get
            {
                return Self.errorMessage;
            }
            set
            {
                Self.errorMessage = value;
            }
        }

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

        List<Map<string, object>> rows
        {
            get
            {
                return Self.rows;
            }
            set
            {
                Self.rows = value;
            }
        }

        bool success
        {
            get
            {
                return Self.success;
            }
            set
            {
                Self.success = value;
            }
        }

        string tableName
        {
            get
            {
                return Self.tableName;
            }
            set
            {
                Self.tableName = value;
            }
        }

        int totalSize
        {
            get
            {
                return Self.totalSize;
            }
            set
            {
                Self.totalSize = value;
            }
        }

        public static TableResult error(string errorMessage)
        {
            return Implementation.error(errorMessage);
        }

        public static TableResult get(bool success, string errorMessage, string tableName, List<Map<string, object>> rows, int totalSize)
        {
            return Implementation.get(success, errorMessage, tableName, rows, totalSize);
        }

        public static TableResult get(bool success, string errorMessage, string tableName, List<Map<string, object>> rows)
        {
            return Implementation.get(success, errorMessage, tableName, rows);
        }

        public static TableResult get(QueryContext queryContext, List<Map<string, object>> rows)
        {
            return Implementation.get(queryContext, rows);
        }

        public static TableResult get(TableSelection tableSelection, List<Map<string, object>> rows)
        {
            return Implementation.get(tableSelection, rows);
        }
    }
}
