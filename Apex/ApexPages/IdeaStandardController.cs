namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_ideastandardcontroller.htm#apex_pages_ideastandardcontroller
    /// </summary>
    public class IdeaStandardController
    {
        // infrastructure
        public IdeaStandardController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(IdeaStandardController));
            }
        }

        // API
        public IdeaComment[] getCommentList()
        {
            return Self.getCommentList();
        }

        public void addFields(List<string> fieldNames)
        {
            Self.addFields(fieldNames);
        }

        public PageReference cancel()
        {
            return Self.cancel();
        }

        public PageReference delete()
        {
            return Self.delete();
        }

        public PageReference edit()
        {
            return Self.edit();
        }

        public string getId()
        {
            return Self.getId();
        }

        public SObject getRecord()
        {
            return Self.getRecord();
        }

        public PageReference save()
        {
            return Self.save();
        }

        public PageReference view()
        {
            return Self.view();
        }
    }
}
