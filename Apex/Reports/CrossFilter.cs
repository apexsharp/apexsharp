namespace Apex.Reports
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_reports_CrossFilter.htm#apex_class_reports_CrossFilter
    /// </summary>
    public class CrossFilter
    {
        // infrastructure
        public CrossFilter(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(CrossFilter));
            }
        }

        // API
        public CrossFilter(List<ReportFilter> criteria, bool includesObject, string primaryEntityField, string relatedEntity, string relatedEntityJoinField)
        {
            Implementation.Constructor(criteria, includesObject, primaryEntityField, relatedEntity, relatedEntityJoinField);
        }

        public CrossFilter()
        {
            Implementation.Constructor();
        }

        public List<ReportFilter> getCriteria()
        {
            return Self.getCriteria();
        }

        public bool getIncludesObject()
        {
            return Self.getIncludesObject();
        }

        public string getPrimaryEntityField()
        {
            return Self.getPrimaryEntityField();
        }

        public string getRelatedEntity()
        {
            return Self.getRelatedEntity();
        }

        public string getRelatedEntityJoinField()
        {
            return Self.getRelatedEntityJoinField();
        }

        public void setCriteria(List<ReportFilter> criteria)
        {
            Self.setCriteria(criteria);
        }

        public void setIncludesObject(bool includesObject)
        {
            Self.setIncludesObject(includesObject);
        }

        public void setPrimaryEntityField(string primaryEntityField)
        {
            Self.setPrimaryEntityField(primaryEntityField);
        }

        public void setRelatedEntity(string relatedEntity)
        {
            Self.setRelatedEntity(relatedEntity);
        }

        public void setRelatedEntityJoinField(string relatedEntityJoinField)
        {
            Self.setRelatedEntityJoinField(relatedEntityJoinField);
        }

        public string toString()
        {
            return Self.toString();
        }

        public object clone()
        {
            return Self.clone();
        }
    }
}
