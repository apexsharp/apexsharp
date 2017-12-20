namespace Apex.System
{
    public class ID : global::System.IEquatable<ID>
    {
        private string _id;
        public static implicit operator ID(string v)
        {
            var id = new ID { _id = v };
            return id;
        }

        public string toString()
        {
            return _id;
        }

        public void addError(object msg)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void addError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void addError(string msg)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void addError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        //    public SObjectType GetSobjectType() { throw new global::System.NotImplementedException("ID.GetSobjectType"); }
        public static ID valueOf(string v)
        {
            var id = new ID { _id = v };
            return id;
        }

        public bool equals(string o) => _id == o;

        public bool equals(ID other) => other != null && other._id == _id;

     //   public override bool equals(object obj) => Equals(obj as ID);

     //   public override int getHashCode() => $"{_id}".GetHashCode();
        public bool Equals(ID other)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }
    }
}