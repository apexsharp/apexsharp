using Apex.ApexSharp.Implementation;
using Apex.Database;
using Apex.Schema;

namespace Apex.System
{
    public abstract class SObject
    {
        public ID Id { get; set; }

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(SObject));

        public void addError(object msg) => NotImplemented.addError(msg);

        public void addError(object msg, bool escape) => NotImplemented.addError(msg, escape);

        public void addError(string msg) => NotImplemented.addError(msg);

        public void addError(string msg, bool escape) => NotImplemented.addError(msg, escape);

        public void clear() => NotImplemented.clear();

        public SObject clone() => NotImplemented.clone();

        public SObject clone(bool preserveId) => NotImplemented.clone(preserveId);

        public SObject clone(bool preserveId, bool deep) => NotImplemented.clone(preserveId, deep);

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps) =>
             NotImplemented.clone(preserveId, deep, preserveReadOnlyTimestamps);

        public SObject clone(bool preserveId, bool deep, bool preserveReadOnlyTimestamps, bool preserveAutoNumbers) =>
             NotImplemented.clone(preserveId, deep, preserveReadOnlyTimestamps, preserveAutoNumbers);

        public object get(SObjectField field) => NotImplemented.get(field);

        public object get(string field) => GetType().GetProperty(field).GetValue(this, null);

        public Map<string, SObject> getAll() => NotImplemented.getAll();

        public ID getCloneSourceId() => NotImplemented.getCloneSourceId();

        public SObject getInstance() => NotImplemented.getInstance();

        public SObject getInstance(string id) => NotImplemented.getInstance(id);

        public DMLOptions getOptions() => NotImplemented.getOptions();

        public SObject getOrgDefaults() => NotImplemented.getOrgDefaults();

        public Map<string, object> getPopulatedFieldsAsMap()
        {
            var map = new Map<string, object>();
            foreach (var p in GetType().GetProperties())
            {
                var value = p.GetValue(this);
                var defValue = Implementor.GetDefault(p.PropertyType);
                if (!Equals(value, defValue))
                {
                    map.put(p.Name, value);
                }
            }

            return map;
        }

        public string getQuickActionName() => NotImplemented.getQuickActionName();

        public SObject getSObject(SObjectField field) => NotImplemented.getSObject(field);

        public SObject getSObject(string field) => NotImplemented.getSObject(field);

        public SObjectType getSObjectType() => NotImplemented.getSObjectType();

        public List<SObject> getSObjects(SObjectField field) => NotImplemented.getSObjects(field);

        public List<SObject> getSObjects(string field) => NotImplemented.getSObjects(field);

        public SObject getValues(string id) => NotImplemented.getValues(id);

        public bool isClone() => NotImplemented.isClone();

        public object put(SObjectField field, object value) => NotImplemented.put(field, value);

        public object put(string field, object value)
        {
            GetType().GetProperty(field).SetValue(this, value);
            return value;
        }

        public SObject putSObject(SObjectField field, SObject value) => NotImplemented.putSObject(field, value);

        public SObject putSObject(string field, SObject value) => NotImplemented.putSObject(field, value);

        public void recalculateFormulas() => NotImplemented.recalculateFormulas();

        public void setOptions(object options) => NotImplemented.setOptions();
    }
}