using Apex.System;

using SObject = Apex.System.SObject;

namespace Apex.Search
{
    public class SearchResult
    {
        public object clone()
        {
            throw new global::System.NotImplementedException("SearchResult.Clone");
        }

        public SObject getSObject()
        {
            throw new global::System.NotImplementedException("SearchResult.GetSObject");
        }

        public string getSnippet()
        {
            throw new global::System.NotImplementedException("SearchResult.GetSnippet");
        }

        public string getSnippet(string field)
        {
            throw new global::System.NotImplementedException("SearchResult.GetSnippet");
        }
    }
}