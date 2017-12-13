using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ApexSharpApi
{
    public class SoqlQuery<T> : IEnumerable<T>
    {
        private static Regex SoqlFieldsRegex { get; } =
            new Regex(@"^select \s+ ((?<Field>[^\,\s]*) \s* \, \s*)* (?<Field>[^\,\s]*) \s* from",
                RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

        public SoqlQuery(Lazy<List<T>> lazyResult, string originalQuery, string preparedQuery = null, params object[] parameters)
        {
            QueryResult = lazyResult;
            OriginalQuery = originalQuery;
            PreparedQuery = preparedQuery ?? originalQuery;
            Parameters = parameters;
            Fields = GetSoqlFields(originalQuery);
        }

        public static string[] GetSoqlFields(string soqlQuery)
        {
            return SoqlFieldsRegex.Match(soqlQuery ?? string.Empty)
                .Groups["Field"].Captures.OfType<Capture>().Select(c => c.Value)
                .Where(f => !string.IsNullOrWhiteSpace(f)).ToArray();
        }

        public string OriginalQuery { get; }

        public string PreparedQuery { get; }

        public object[] Parameters { get; }

        public string[] Fields { get; }

        public Lazy<List<T>> QueryResult { get; }

        public IEnumerator<T> GetEnumerator() => QueryResult.Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => QueryResult.Value.GetEnumerator();

        public static implicit operator string(SoqlQuery<T> query) => query.OriginalQuery;

        public static implicit operator List<T>(SoqlQuery<T> query) => query.QueryResult.Value;

        public static implicit operator T[] (SoqlQuery<T> query) => query.QueryResult.Value.ToArray();

        public static implicit operator T(SoqlQuery<T> query) => query.QueryResult.Value.FirstOrDefault();
    }
}
