namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_UpsertContext.htm#apex_class_DataSource_UpsertContext
    /// </summary>
    public class UpsertContext
    {
        // infrastructure
        public UpsertContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(UpsertContext));
            }
        }

        // API
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

        string tableSelected
        {
            get
            {
                return Self.tableSelected;
            }
            set
            {
                Self.tableSelected = value;
            }
        }
    }
}
