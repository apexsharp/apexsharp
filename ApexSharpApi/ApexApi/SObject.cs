namespace ApexSharpApi.ApexApi
{
    public abstract class SObject
    {
        public ID Id { get; set; }

        public void AddError(object msg)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void AddError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void AddError(string msg)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void AddError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("SObject.AddError");
        }

        public void Clear()
        {
            throw new global::System.NotImplementedException("SObject.Clear");
        }

        public SObject Clone()
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject Clone(bool preserveId)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject Clone(bool preserveId, bool deep)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject Clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        public SObject Clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers)
        {
            throw new global::System.NotImplementedException("SObject.Clone");
        }

        //  public object Get(SObjectField field)
        //  {
        //      throw new global::System.NotImplementedException("SObject.Get");
        //  }

        public object Get(string field)
        {
            throw new global::System.NotImplementedException("SObject.Get");
        }

        //public Map<String, SObject> GetAll()
        //{
        //    throw new global::System.NotImplementedException("SObject.GetAll");
        // }

        public ID GetCloneSourceId()
        {
            throw new global::System.NotImplementedException("SObject.GetCloneSourceId");
        }

        public SObject GetInstance()
        {
            throw new global::System.NotImplementedException("SObject.GetInstance");
        }

        public SObject GetInstance(string id)
        {
            throw new global::System.NotImplementedException("SObject.GetInstance");
        }

        //     public DMLOptions GetOptions()
        //     {
        //        throw new global::System.NotImplementedException("SObject.GetOptions");
        //    }

        public SObject GetOrgDefaults()
        {
            throw new global::System.NotImplementedException("SObject.GetOrgDefaults");
        }

        ////   public Map<String, Object> GetPopulatedFieldsAsMap()
        //  {
        //      throw new global::System.NotImplementedException("SObject.GetPopulatedFieldsAsMap");
        //  }

        //  public string GetQuickActionName()
        //  {
        //       throw new global::System.NotImplementedException("SObject.GetQuickActionName");
        //   }

        //public SObject GetSObject(SObjectField field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObject");
        //}

        //public SObject GetSObject(string field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObject");
        //}

        //public SObjectType GetSObjectType()
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjectType");
        //}

        //public List<SObject> GetSObjects(SObjectField field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjects");
        //}

        //public List<SObject> GetSObjects(string field)
        //{
        //    throw new global::System.NotImplementedException("SObject.GetSObjects");
        //}

        public SObject GetValues(string id)
        {
            throw new global::System.NotImplementedException("SObject.GetValues");
        }

        public bool IsClone()
        {
            throw new global::System.NotImplementedException("SObject.IsClone");
        }

        //public object Put(SObjectField field, object value)
        //{
        //    throw new global::System.NotImplementedException("SObject.Put");
        //}

        public object Put(string field, object value)
        {
            throw new global::System.NotImplementedException("SObject.Put");
        }

        //public SObject PutSObject(SObjectField field, SObject value)
        //{
        //    throw new global::System.NotImplementedException("SObject.PutSObject");
        //}

        public SObject PutSObject(string field, SObject value)
        {
            throw new global::System.NotImplementedException("SObject.PutSObject");
        }

        public void RecalculateFormulas()
        {
            throw new global::System.NotImplementedException("SObject.RecalculateFormulas");
        }

        public void SetOptions(object options)
        {
            throw new global::System.NotImplementedException("SObject.SetOptions");
        }
    }
}