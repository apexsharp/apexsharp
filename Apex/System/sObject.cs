namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.Database;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public class SObject
    {
        // infrastructure
        public SObject(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(SObject));
            }
        }

        // API
        ID Id
        {
            get
            {
                return Self.Id;
            }
            set
            {
                Self.Id = value;
            }
        }

        public void addError(Exception msg, bool escape)
        {
            Self.addError(msg, escape);
        }

        public void addError(Exception msg)
        {
            Self.addError(msg);
        }

        public void clear()
        {
            Self.clear();
        }

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers)
        {
            return Self.clone(preserveId, deep, preserveReadOnlyTimestamps, preserveAutoNumbers);
        }

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps)
        {
            return Self.clone(preserveId, deep, preserveReadOnlyTimestamps);
        }

        public SObject clone(bool preserveId, bool deep)
        {
            return Self.clone(preserveId, deep);
        }

        public SObject clone(bool preserveId)
        {
            return Self.clone(preserveId);
        }

        public SObject clone()
        {
            return Self.clone();
        }

        public object get(SObjectField field)
        {
            return Self.get(field);
        }

        public object get(string field)
        {
            return Self.get(field);
        }

        public Map<string, SObject> getAll()
        {
            return Self.getAll();
        }

        public ID getCloneSourceId()
        {
            return Self.getCloneSourceId();
        }

        public SObject getInstance()
        {
            return Self.getInstance();
        }

        public SObject getInstance(string id)
        {
            return Self.getInstance(id);
        }

        public DMLOptions getOptions()
        {
            return Self.getOptions();
        }

        public SObject getOrgDefaults()
        {
            return Self.getOrgDefaults();
        }

        public Map<string, object> getPopulatedFieldsAsMap()
        {
            return Self.getPopulatedFieldsAsMap();
        }

        public string getQuickActionName()
        {
            return Self.getQuickActionName();
        }

        public SObject getSObject(SObjectField field)
        {
            return Self.getSObject(field);
        }

        public SObject getSObject(string field)
        {
            return Self.getSObject(field);
        }

        public List<SObject> getSObjects(SObjectField field)
        {
            return Self.getSObjects(field);
        }

        public List<SObject> getSObjects(string field)
        {
            return Self.getSObjects(field);
        }

        public SObjectType getSObjectType()
        {
            return Self.getSObjectType();
        }

        public SObject getValues(string id)
        {
            return Self.getValues(id);
        }

        public bool isClone()
        {
            return Self.isClone();
        }

        public object put(SObjectField field, object value)
        {
            return Self.put(field, value);
        }

        public object put(string field, object value)
        {
            return Self.put(field, value);
        }

        public SObject putSObject(SObjectField field, SObject value)
        {
            return Self.putSObject(field, value);
        }

        public SObject putSObject(string field, SObject value)
        {
            return Self.putSObject(field, value);
        }

        public void recalculateFormulas()
        {
            Self.recalculateFormulas();
        }

        public void setOptions(DMLOptions options)
        {
            Self.setOptions(options);
        }
    }
}
