namespace ApexSharpApi.ApexApi
{
    public class ID : System.IEquatable<ID>
    {
        private string _id;
        public static implicit operator ID(string v)
        {
            var id = new ID { _id = v };
            return id;
        }

        public override string ToString()
        {
            return _id;
        }

        public void AddError(object msg)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void AddError(object msg, bool escape)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void AddError(string msg)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        public void AddError(string msg, bool escape)
        {
            throw new global::System.NotImplementedException("ID.AddError");
        }

        //    public SObjectType GetSobjectType() { throw new global::System.NotImplementedException("ID.GetSobjectType"); }
        public static ID ValueOf(string v)
        {
            var id = new ID { _id = v };
            return id;
        }

        public bool Equals(string o) => _id == o;

        public bool Equals(ID other) => other != null && other._id == _id;

        public override bool Equals(object obj) => Equals(obj as ID);

        public override int GetHashCode() => $"{_id}".GetHashCode();
    }
}