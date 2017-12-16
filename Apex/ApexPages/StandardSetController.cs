namespace Apex.ApexPages
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_pages_standardsetcontroller.htm#apex_pages_standardsetcontroller
    /// </summary>
    public class StandardSetController
    {
        // infrastructure
        public StandardSetController(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(StandardSetController));
            }
        }

        // API
        public StandardSetController(QueryLocator queryLocator)
        {
            Implementation.Constructor(queryLocator);
        }

        public StandardSetController(List<SObject> controllerSObjects)
        {
            Implementation.Constructor(controllerSObjects);
        }

        public PageReference cancel()
        {
            return Self.cancel();
        }

        public void first()
        {
            Self.first();
        }

        public bool getCompleteResult()
        {
            return Self.getCompleteResult();
        }

        public string getFilterId()
        {
            return Self.getFilterId();
        }

        public bool getHasNext()
        {
            return Self.getHasNext();
        }

        public bool getHasPrevious()
        {
            return Self.getHasPrevious();
        }

        public SelectOption getListViewOptions()
        {
            return Self.getListViewOptions();
        }

        public int getPageNumber()
        {
            return Self.getPageNumber();
        }

        public int getPageSize()
        {
            return Self.getPageSize();
        }

        public SObject getRecord()
        {
            return Self.getRecord();
        }

        public SObject[] getRecords()
        {
            return Self.getRecords();
        }

        public int getResultSize()
        {
            return Self.getResultSize();
        }

        public SObject[] getSelected()
        {
            return Self.getSelected();
        }

        public void last()
        {
            Self.last();
        }

        public void next()
        {
            Self.next();
        }

        public void previous()
        {
            Self.previous();
        }

        public PageReference save()
        {
            return Self.save();
        }

        public void setFilterID(string filterId)
        {
            Self.setFilterID(filterId);
        }

        public void setpageNumber(int pageNumber)
        {
            Self.setpageNumber(pageNumber);
        }

        public void setPageSize(int pageSize)
        {
            Self.setPageSize(pageSize);
        }

        public void setSelected(SObject[] selectedRecords)
        {
            Self.setSelected(selectedRecords);
        }

        public void addFields(List<string> fieldNames)
        {
            Self.addFields(fieldNames);
        }

        public void setFilterId(string filterId)
        {
            Self.setFilterId(filterId);
        }

        public void setPageNumber(int pageNumber)
        {
            Self.setPageNumber(pageNumber);
        }

        public void setSelected(List<SObject> selected)
        {
            Self.setSelected(selected);
        }
    }
}
