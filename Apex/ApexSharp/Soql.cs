using Apex.System;
using ApexSharpApi;

namespace Apex.ApexSharp
{

    using ApexSharpApi.ApexApi;

    public class Soql
    {
        public static SoqlQuery<T> Query<T>(string soql, params object[] parameters)
        {
            return SoqlApi.Query<T>(soql, parameters);
        }

        public static SoqlQuery<T> Query<T>(string soql)
        {
            return SoqlApi.Query<T>(soql);
        }

        public static void Insert<T>(T sObject) where T : SObject
        {
            SoqlApi.Insert(sObject);
        }

        public static void Update<T>(T sObject) where T : SObject
        {
            SoqlApi.Update(sObject);
        }

        public static void Update<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Update(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static void Delete<T>(T sObject) where T : SObject
        {
            SoqlApi.Delete(sObject);
        }

        public static void Delete<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Delete(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static SoqlQuery<T> query<T>(string soql, params object[] parameters)
        {
            return SoqlApi.Query<T>(soql, parameters);
        }

        public static SoqlQuery<T> query<T>(string soql)
        {
            return SoqlApi.Query<T>(soql);
        }

        public static void insert<T>(T sObject) where T : SObject
        {
            SoqlApi.Insert(sObject);
        }

        public static void update<T>(T sObject) where T : SObject
        {
            SoqlApi.Update(sObject);
        }

        public static void update<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Update(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static void delete<T>(T sObject) where T : SObject
        {
            SoqlApi.Delete(sObject);
        }

        public static void delete<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Delete(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static void upsert<T>(List<T> sObjectList) where T : SObject
        {
            SoqlApi.Upsert(sObjectList as global::System.Collections.Generic.IEnumerable<T>);
        }

        public static void upsert<T>(T sObject) where T : SObject
        {
            SoqlApi.Upsert(sObject);
        }
    }
}