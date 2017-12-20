using Apex.Schema;

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

        public object get(SObjectField field)
        {
            throw new global::System.NotImplementedException("SObject.Get");
        }

        //public Map<string, SObject> GetAll()
        //{
        //throw new global::System.NotImplementedException("SObject.GetAll");
        //}

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

        //     public DMLOptions GetOptions()
        //     {
        //        throw new global::System.NotImplementedException("SObject.GetOptions");
        //    }

        public SObject getOrgDefaults()
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

        public SObject getValues(string id)
        {
            throw new global::System.NotImplementedException("SObject.GetValues");
        }

        public bool isClone()
        {
            throw new global::System.NotImplementedException("SObject.IsClone");
        }

        //public object Put(SObjectField field, object value)
        //{
        //    throw new global::System.NotImplementedException("SObject.Put");
        //}

        public object put(string field, object value)
        {
            throw new global::System.NotImplementedException("SObject.Put");
        }

        //public SObject PutSObject(SObjectField field, SObject value)
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