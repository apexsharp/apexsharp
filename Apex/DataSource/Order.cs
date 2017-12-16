namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_Order.htm#apex_class_DataSource_Order
    /// </summary>
    public class Order
    {
        // infrastructure
        public Order(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Order));
            }
        }

        // API
        string columnName
        {
            get
            {
                return Self.columnName;
            }
            set
            {
                Self.columnName = value;
            }
        }

        OrderDirection direction
        {
            get
            {
                return Self.direction;
            }
            set
            {
                Self.direction = value;
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

        public static Order get(string tableName, string columnName, OrderDirection direction)
        {
            return Implementation.get(tableName, columnName, direction);
        }
    }
}
