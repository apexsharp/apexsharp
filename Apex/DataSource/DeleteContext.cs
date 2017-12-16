namespace Apex.DataSource
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_DataSource_DeleteContext.htm#apex_class_DataSource_DeleteContext
    /// </summary>
    public class DeleteContext
    {
        // infrastructure
        public DeleteContext(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(DeleteContext));
            }
        }

        // API
        List<string> externalIds
        {
            get
            {
                return Self.externalIds;
            }
            set
            {
                Self.externalIds = value;
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
