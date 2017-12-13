using Apex.Database;
using ApexSharpApi.ApexApi;

namespace Apex.System
{
    public class Database
    {
        public class QueryLocator
        {
            public string getQuery()
            {
                throw new global::System.NotImplementedException("QueryLocator.GetQuery");
            }

            //public Database.QueryLocatorIterator Iterator()
            //{
            //    throw new global::System.NotImplementedException("QueryLocator.Iterator");
            //}

            public List<SObject> querymore(int num)
            {
                throw new global::System.NotImplementedException("QueryLocator.Querymore");
            }
        }

        public class BatchableContext
        {
            public ID getChildJobId()
            {
                throw new global::System.NotImplementedException("BatchableContext.GetChildJobId");
            }

            public ID getJobId()
            {
                throw new global::System.NotImplementedException("BatchableContext.GetJobId");
            }
        }

        public static LeadConvertResult convertLead(LeadConvert leadConvert)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static LeadConvertResult convertLead(LeadConvert leadConvert, object DmlOptions)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static LeadConvertResult convertLead(LeadConvert leadConvert, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts, object DmlOptions)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.ConvertLead");
        }

        public static int countQuery(string query)
        {
            throw new global::System.NotImplementedException("Database.CountQuery");
        }

        public static DeleteResult delete(ID id)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static DeleteResult delete(ID id, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static List<DeleteResult> delete(List<ID> ids)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static List<DeleteResult> delete(List<ID> ids, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static List<DeleteResult> delete(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static List<DeleteResult> delete(List<SObject> sobjects, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static DeleteResult delete(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static DeleteResult delete(SObject sobject, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Delete");
        }

        public static List<DeleteResult> deleteAsync(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.DeleteAsync");
        }

        public static List<DeleteResult> deleteAsync(List<SObject> sobjects, object callback)
        {
            throw new global::System.NotImplementedException("Database.DeleteAsync");
        }

        public static DeleteResult deleteAsync(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.DeleteAsync");
        }

        public static DeleteResult deleteAsync(SObject sobject, object callback)
        {
            throw new global::System.NotImplementedException("DeleteAsync");
        }

        public static List<DeleteResult> deleteImmediate(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.DeleteImmediate");
        }

        public static DeleteResult deleteImmediate(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.DeleteImmediate");
        }

        public static List<EmptyRecycleBinResult> emptyRecycleBin(List<ID> ids)
        {
            throw new global::System.NotImplementedException("Database.EmptyRecycleBin");
        }

        public static List<EmptyRecycleBinResult> emptyRecycleBin(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.EmptyRecycleBin");
        }

        public static EmptyRecycleBinResult emptyRecycleBin(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.EmptyRecycleBin");
        }

        public static string executeBatch(object batchable)
        {
            throw new global::System.NotImplementedException("Database.ExecuteBatch");
        }

        public static string executeBatch(object batchable, int batchSize)
        {
            throw new global::System.NotImplementedException("Database.ExecuteBatch");
        }

        public static DeleteResult getAsyncDeleteResult(object deleteResult)
        {
            throw new global::System.NotImplementedException("Database.GetAsyncDeleteResult");
        }

        public static DeleteResult getAsyncDeleteResult(string asyncLocator)
        {
            throw new global::System.NotImplementedException("Database.GetAsyncDeleteResult");
        }

        public static string getAsyncLocator(object result)
        {
            throw new global::System.NotImplementedException("Database.GetAsyncLocator");
        }

        public static SaveResult getAsyncSaveResult(object saveResult)
        {
            throw new global::System.NotImplementedException("Database.GetAsyncSaveResult");
        }

        public static SaveResult getAsyncSaveResult(string asyncLocator)
        {
            throw new global::System.NotImplementedException("Database.GetAsyncSaveResult");
        }

        public static GetDeletedResult getDeleted(string sobjectType, DateTime startDate, DateTime endDate)
        {
            throw new global::System.NotImplementedException("Database.GetDeleted");
        }

        public static QueryLocator getQueryLocator(List<SObject> query)
        {
            throw new global::System.NotImplementedException("Database.GetQueryLocator");
        }

        public static QueryLocator getQueryLocator(string query)
        {
            throw new global::System.NotImplementedException("Database.GetQueryLocator");
        }

        public static GetUpdatedResult getUpdated(string sobjectType, DateTime startDate, DateTime endDate)
        {
            throw new global::System.NotImplementedException("Database.GetUpdated");
        }

        public static List<SaveResult> insert(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.Insert");
        }

        public static List<SaveResult> insert(List<SObject> sobjects, object DmlOptions)
        {
            throw new global::System.NotImplementedException("Database.Insert");
        }

        public static List<SaveResult> insert(List<SObject> sobjects, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Insert");
        }

        public static SaveResult insert(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.Insert");
        }

        public static SaveResult insert(SObject sobject, object DmlOptions)
        {
            throw new global::System.NotImplementedException("Database.Insert");
        }

        public static SaveResult insert(SObject sobject, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Insert");
        }

        public static List<SaveResult> insertAsync(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("InsertAsync");
        }

        public static List<SaveResult> insertAsync(List<SObject> sobjects, object callback)
        {
            throw new global::System.NotImplementedException("Database.InsertAsync");
        }

        public static SaveResult insertAsync(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.InsertAsync");
        }

        public static SaveResult insertAsync(SObject sobject, object callback)
        {
            throw new global::System.NotImplementedException("Database.InsertAsync");
        }

        public static List<SaveResult> insertImmediate(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.InsertImmediate");
        }

        public static SaveResult insertImmediate(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.InsertImmediate");
        }

        public static MergeResult merge(SObject master, ID duplicate)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static MergeResult merge(SObject master, ID duplicate, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static List<MergeResult> merge(SObject master, List<ID> duplicates)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static List<MergeResult> merge(SObject master, List<ID> duplicates, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static List<MergeResult> merge(SObject master, List<SObject> duplicates)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static List<MergeResult> merge(SObject master, List<SObject> duplicates, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static MergeResult merge(SObject master, SObject duplicate)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static MergeResult merge(SObject master, SObject duplicate, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Merge");
        }

        public static List<SObject> query(string query)
        {
            throw new global::System.NotImplementedException("Database.Query");
        }

        //public static void Rollback(Savepoint savepoint){throw new global::System.NotImplementedException("Database.Rollback");}
        //public static Savepoint SetSavepoint(){throw new global::System.NotImplementedException("Database.SetSavepoint");}
        public static UndeleteResult undelete(ID id)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static UndeleteResult undelete(ID id, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static List<UndeleteResult> undelete(List<ID> ids)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static List<UndeleteResult> undelete(List<ID> ids, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static List<UndeleteResult> undelete(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Undelete");
        }

        public static List<UndeleteResult> undelete(List<SObject> sobjects, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static UndeleteResult undelete(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static UndeleteResult undelete(SObject sobject, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Undelete");
        }

        public static List<SaveResult> update(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static List<SaveResult> update(List<SObject> sobjects, object allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static List<SaveResult> update(List<SObject> sobjects, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static SaveResult update(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static SaveResult update(SObject sobject, object allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static SaveResult update(SObject sobject, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Update");
        }

        public static List<SaveResult> updateAsync(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.UpdateAsync");
        }

        public static List<SaveResult> updateAsync(List<SObject> sobjects, object callback)
        {
            throw new global::System.NotImplementedException("Database.UpdateAsync");
        }

        public static SaveResult updateAsync(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.UpdateAsync");
        }

        public static SaveResult updateAsync(SObject sobject, object callback)
        {
            throw new global::System.NotImplementedException("Database.UpdateAsync");
        }

        public static List<SaveResult> updateImmediate(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.UpdateImmediate");
        }

        public static SaveResult updateImmediate(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.UpdateImmediate");
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects)
        {
            throw new global::System.NotImplementedException("Database.Upsert");
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Upsert");
        }

        //public static List<UpsertResult> Upsert(List<SObject> sobjects,Schema.SObjectField field){throw new global::System.NotImplementedException("Database.Upsert");}
        //public static List<UpsertResult> Upsert(List<SObject> sobjects,Schema.SObjectField field,bool allOrNothing){throw new global::System.NotImplementedException("Database.Upsert");}
        public static UpsertResult upsert(SObject sobject)
        {
            throw new global::System.NotImplementedException("Database.Upsert");
        }

        public static UpsertResult upsert(SObject sobject, bool allOrNothing)
        {
            throw new global::System.NotImplementedException("Database.Upsert");
        }

        //public static UpsertResult Upsert(SObject sobject,Schema.SObjectField field,bool allOrNothing){throw new global::System.NotImplementedException("Database.Upsert");}
        //public static UpsertResult Upsert(SObject sobject,Schema.SObjectField field){throw new global::System.NotImplementedException("Database.Upsert");}
    }
}