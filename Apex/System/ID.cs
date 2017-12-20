namespace ApexSharpApi.ApexApi
{
    public class ID : System.IEquatable<ID>
    {
        private string _id;

        public static implicit operator ID(string v) => new ID(v);

        public ID(ID other) => _id = other._id;

        public ID(string other) => _id = other;

        public string toString() => _id;

        public void addError(object msg) => throw new global::System.NotImplementedException("ID.AddError");

        public void addError(object msg, bool escape) => throw new global::System.NotImplementedException("ID.AddError");

        public void addError(string msg) => throw new global::System.NotImplementedException("ID.AddError");

        public void addError(string msg, bool escape) => throw new global::System.NotImplementedException("ID.AddError");

        //public SObjectType GetSobjectType() { throw new global::System.NotImplementedException("ID.GetSobjectType"); }

        public static ID valueOf(string v) => new ID(v);

        public bool equals(string other) => Equals(other);

        public bool equals(ID other) => Equals(other);

        public bool Equals(string o) => _id == o;

        public bool Equals(ID other) => other != null && other._id == _id;

        public override bool Equals(object obj) => Equals(obj as ID);

        public override int GetHashCode() => $"{_id}".GetHashCode();

        public override string ToString() => _id;
    }
}