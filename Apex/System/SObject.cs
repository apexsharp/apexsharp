namespace Apex.System
{
    public abstract class SObject
    {
        public ID Id { get; set; }

        public void addError(object msg)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void addError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void addError(string msg)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void addError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void clear()
        {
            throw new global::System.NotImplementedException("SObject.Clear");
        }

        public SObject clone()
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject clone(bool preserveId)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject clone(bool preserveId, bool deep)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        //  public object get(SObjectField field)
        //  {
        //      throw new global::System.NotImplementedException("SObject.Get");
        //  }

        public object get(string field)
        {
            return this.GetType().GetProperty(field).GetValue(this, null);
        }

        //public Map<String, SObject> getAll()
        //{
        //    throw new global::System.NotImplementedException("SObject.GetAll");
        // }

        public ID getCloneSourceId()
        {
            throw new global::System.NotImplementedException("SObject.GetCloneSourceId");
        }

        public SObject getInstance()
        {
            throw new global::System.NotImplementedException("SObject.GetInstance");
        }

        public SObject getInstance(string id)
        {
            throw new global::System.NotImplementedException("SObject.GetInstance");
        }

        //     public DMLOptions getOptions()
        //     {
        //        throw new global::System.NotImplementedException("SObject.GetOptions");
        //    }

        public SObject getOrgDefaults()
        {
            throw new global::System.NotImplementedException("SObject.GetOrgDefaults");
        }

        ////   public Map<String, Object> getPopulatedFieldsAsMap()
        //  {
        //      throw new global::System.NotImplementedException("SObject.GetPopulatedFieldsAsMap");
        //  }

        //  public string getQuickActionName()
        //  {
        //       throw new global::System.NotImplementedException("SObject.GetQuickActionName");
        //   }

        //public SObject getSObject(SObjectField field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObject");
        //}

        //public SObject getSObject(string field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObject");
        //}

        //public SObjectType getSObjectType()
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjectType");
        //}

        //public List<SObject> getSObjects(SObjectField field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjects");
        //}

        //public List<SObject> getSObjects(string field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjects");
        //}

        public SObject getValues(string id)
        {
            throw new global::System.NotImplementedException("SObject.GetValues");
        }

        public bool isClone()
        {
            throw new global::System.NotImplementedException("SObject.IsClone");
        }

        //public object put(SObjectField field, object value)
        //{
        //    throw new global::System.NotImplementedException("SObject.Put");
        //}

        public object put(string field, object value)
        {
            throw new global::System.NotImplementedException("SObject.Put");
        }

        //public SObject putSObject(SObjectField field, SObject value)
        //{
        //    throw new global::System.NotImplementedException("SObject.PutSObject");
        //}

        public SObject putSObject(string field, SObject value)
        {
            throw new global::System.NotImplementedException("SObject.PutSObject");
        }

        public void recalculateFormulas()
        {
            throw new global::System.NotImplementedException("SObject.RecalculateFormulas");
        }

        public void setOptions(object options)
        {
            throw new global::System.NotImplementedException("SObject.SetOptions");
        }
    }
}