namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_knowledgearticleversionstandardcontroller.htm#apex_pages_knowledgearticleversionstandardcontroller
    /// </summary>
    public class KnowledgeArticleVersionStandardController
    {
        // infrastructure
        public KnowledgeArticleVersionStandardController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(KnowledgeArticleVersionStandardController));
            }
        }

        // API
        public KnowledgeArticleVersionStandardController(SObject article)
        {
            Self = Implementation.Constructor(article);
        }

        public string getSourceId()
        {
            return Self.getSourceId();
        }

        public void setDataCategory(string categoryGroup, string category)
        {
            Self.setDataCategory(categoryGroup, category);
        }

        public void addFields(List<string> fieldNames)
        {
            Self.addFields(fieldNames);
        }

        public PageReference cancel()
        {
            return Self.cancel();
        }

        public string getId()
        {
            return Self.getId();
        }

        public SObject getRecord()
        {
            return Self.getRecord();
        }

        public void selectDataCategory(string categoryGroup, string category)
        {
            Self.selectDataCategory(categoryGroup, category);
        }

        public PageReference view()
        {
            return Self.view();
        }
    }
}
