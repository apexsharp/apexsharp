namespace Apex.System
{
    public class RestRequest
    {
        public Blob RequestBody { set; get; }
        public RestRequest()
        {

        }

        public void addHeader(string name, string value)
        {
            throw new global::System.NotImplementedException("RestRequest.AddHeader");
        }

        public void addParameter(string name, string value)
        {
            throw new global::System.NotImplementedException("RestRequest.AddParameter");
        }

        public object clone()
        {
            throw new global::System.NotImplementedException("RestRequest.Clone");
        }
    }
}