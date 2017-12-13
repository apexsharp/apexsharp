namespace ApexSharpApi.Model.RestApi
{
    public class SObjectDescribe
    {
        public string encoding { get; set; }
        public int maxBatchSize { get; set; }
        public Sobject[] sobjects { get; set; }
    }

    public class Sobject
    {
        public bool downloaded { get; set; }
        public bool activateable { get; set; }
        public bool createable { get; set; }
        public bool custom { get; set; }
        public bool customSetting { get; set; }
        public bool deletable { get; set; }
        public bool deprecatedAndHidden { get; set; }
        public bool feedEnabled { get; set; }
        public string keyPrefix { get; set; }
        public string label { get; set; }
        public string labelPlural { get; set; }
        public bool layoutable { get; set; }
        public bool mergeable { get; set; }
        public bool mruEnabled { get; set; }
        public string name { get; set; }
        public bool queryable { get; set; }
        public bool replicateable { get; set; }
        public bool retrieveable { get; set; }
        public bool searchable { get; set; }
        public bool triggerable { get; set; }
        public bool undeletable { get; set; }
        public bool updateable { get; set; }
        public Urls urls { get; set; }
    }

    //public class Urls
    //{
    //    public string rowTemplate { get; set; }
    //    public string defaultValues { get; set; }
    //    public string describe { get; set; }
    //    public string sobject { get; set; }
    //    public string compactLayouts { get; set; }
    //    public string approvalLayouts { get; set; }
    //    public string listviews { get; set; }
    //    public string quickActions { get; set; }
    //    public string layouts { get; set; }
    //    public string caseArticleSuggestions { get; set; }
    //    public string caseRowArticleSuggestions { get; set; }
    //    public string push { get; set; }
    //    public string namedLayouts { get; set; }
    //    public string passwordUtilities { get; set; }
    //}
}