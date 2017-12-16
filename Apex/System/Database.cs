namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.Database;
    using global::Apex.DataSource;
    using global::Apex.Schema;
    using global::Apex.System;
    using DeleteResult = global::Apex.Database.DeleteResult;
    using UpsertResult = global::Apex.Database.UpsertResult;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_database.htm#apex_methods_system_database
    /// </summary>
    public class Database
    {
        // infrastructure
        public Database(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Database));
            }
        }

        // API
        public static LeadConvertResult convertLead(LeadConvert leadToConvert, bool allOrNone)
        {
            return Implementation.convertLead(leadToConvert, allOrNone);
        }

        public static int countQuery(string query)
        {
            return Implementation.countQuery(query);
        }

        public static DeleteResult delete(SObject recordToDelete, bool allOrNone)
        {
            return Implementation.delete(recordToDelete, allOrNone);
        }

        public static DeleteResult delete(ID recordID, bool allOrNone)
        {
            return Implementation.delete(recordID, allOrNone);
        }

        public static List<DeleteResult> deleteAsync(List<SObject> sobjects, AsyncDeleteCallback callback)
        {
            return Implementation.deleteAsync(sobjects, callback);
        }

        public static DeleteResult deleteAsync(SObject sobject, AsyncDeleteCallback callback)
        {
            return Implementation.deleteAsync(sobject, callback);
        }

        public static List<DeleteResult> deleteAsync(List<SObject> sobjects)
        {
            return Implementation.deleteAsync(sobjects);
        }

        public static DeleteResult deleteAsync(SObject sobject)
        {
            return Implementation.deleteAsync(sobject);
        }

        public static List<DeleteResult> deleteImmediate(List<SObject> sobjects)
        {
            return Implementation.deleteImmediate(sobjects);
        }

        public static DeleteResult deleteImmediate(SObject sobject)
        {
            return Implementation.deleteImmediate(sobject);
        }

        public static EmptyRecycleBinResult[] emptyRecycleBin(ID[] recordIds)
        {
            return Implementation.emptyRecycleBin(recordIds);
        }

        public static EmptyRecycleBinResult emptyRecycleBin(SObject obj)
        {
            return Implementation.emptyRecycleBin(obj);
        }

        public static ID executeBatch(object batchClassObject)
        {
            return Implementation.executeBatch(batchClassObject);
        }

        public static ID executeBatch(object batchClassObject, int scope)
        {
            return Implementation.executeBatch(batchClassObject, scope);
        }

        public static DeleteResult getAsyncDeleteResult(DeleteResult deleteResult)
        {
            return Implementation.getAsyncDeleteResult(deleteResult);
        }

        public static DeleteResult getAsyncDeleteResult(string asyncLocator)
        {
            return Implementation.getAsyncDeleteResult(asyncLocator);
        }

        public static string getAsyncLocator(object result)
        {
            return Implementation.getAsyncLocator(result);
        }

        public static SaveResult getAsyncSaveResult(SaveResult saveResult)
        {
            return Implementation.getAsyncSaveResult(saveResult);
        }

        public static SaveResult getAsyncSaveResult(string asyncLocator)
        {
            return Implementation.getAsyncSaveResult(asyncLocator);
        }

        public static GetDeletedResult getDeleted(string sObjectType, Datetime startDate, Datetime endDate)
        {
            return Implementation.getDeleted(sObjectType, startDate, endDate);
        }

        public static QueryLocator getQueryLocator(SObject[] listOfQueries)
        {
            return Implementation.getQueryLocator(listOfQueries);
        }

        public static QueryLocator getQueryLocator(string query)
        {
            return Implementation.getQueryLocator(query);
        }

        public static GetUpdatedResult getUpdated(string sobjectType, Datetime startDate, Datetime endDate)
        {
            return Implementation.getUpdated(sobjectType, startDate, endDate);
        }

        public static SaveResult insert(SObject recordToInsert, bool allOrNone)
        {
            return Implementation.insert(recordToInsert, allOrNone);
        }

        public static SaveResult insert(SObject recordToInsert, DMLOptions dmlOptions)
        {
            return Implementation.insert(recordToInsert, dmlOptions);
        }

        public static List<SaveResult> insertAsync(List<SObject> sobjects, AsyncSaveCallback callback)
        {
            return Implementation.insertAsync(sobjects, callback);
        }

        public static SaveResult insertAsync(SObject sobject, AsyncSaveCallback callback)
        {
            return Implementation.insertAsync(sobject, callback);
        }

        public static List<SaveResult> insertAsync(List<SObject> sobjects)
        {
            return Implementation.insertAsync(sobjects);
        }

        public static SaveResult insertAsync(SObject sobject)
        {
            return Implementation.insertAsync(sobject);
        }

        public static List<SaveResult> insertImmediate(List<SObject> sobjects)
        {
            return Implementation.insertImmediate(sobjects);
        }

        public static SaveResult insertImmediate(SObject sobject)
        {
            return Implementation.insertImmediate(sobject);
        }

        public static MergeResult merge(SObject masterRecord, ID duplicateId)
        {
            return Implementation.merge(masterRecord, duplicateId);
        }

        public static MergeResult merge(SObject masterRecord, SObject duplicateRecord)
        {
            return Implementation.merge(masterRecord, duplicateRecord);
        }

        public static List<MergeResult> merge(SObject masterRecord, List<ID> duplicateIds)
        {
            return Implementation.merge(masterRecord, duplicateIds);
        }

        public static MergeResult merge(SObject masterRecord, ID duplicateId, bool allOrNone)
        {
            return Implementation.merge(masterRecord, duplicateId, allOrNone);
        }

        public static MergeResult merge(SObject masterRecord, SObject duplicateRecord, bool allOrNone)
        {
            return Implementation.merge(masterRecord, duplicateRecord, allOrNone);
        }

        public static List<MergeResult> merge(SObject masterRecord, List<ID> duplicateIds, bool allOrNone)
        {
            return Implementation.merge(masterRecord, duplicateIds, allOrNone);
        }

        public static SObject[] query(string queryString)
        {
            return Implementation.query(queryString);
        }

        public static void rollback(Savepoint databaseSavepoint)
        {
            Implementation.rollback(databaseSavepoint);
        }

        public static Savepoint setSavepoint()
        {
            return Implementation.setSavepoint();
        }

        public static UndeleteResult undelete(SObject recordToUndelete, bool allOrNone)
        {
            return Implementation.undelete(recordToUndelete, allOrNone);
        }

        public static UndeleteResult undelete(ID recordID, bool allOrNone)
        {
            return Implementation.undelete(recordID, allOrNone);
        }

        public static SaveResult update(SObject recordToUpdate, bool allOrNone)
        {
            return Implementation.update(recordToUpdate, allOrNone);
        }

        public static SaveResult update(SObject recordToUpdate, DMLOptions dmlOptions)
        {
            return Implementation.update(recordToUpdate, dmlOptions);
        }

        public static UpsertResult upsert(SObject recordToUpsert, SObjectField externalIDField, bool allOrNone)
        {
            return Implementation.upsert(recordToUpsert, externalIDField, allOrNone);
        }

        public static List<SaveResult> updateAsync(List<SObject> sobjects, AsyncSaveCallback callback)
        {
            return Implementation.updateAsync(sobjects, callback);
        }

        public static SaveResult updateAsync(SObject sobject, AsyncSaveCallback callback)
        {
            return Implementation.updateAsync(sobject, callback);
        }

        public static List<SaveResult> updateAsync(List<SObject> sobjects)
        {
            return Implementation.updateAsync(sobjects);
        }

        public static SaveResult updateAsync(SObject sobject)
        {
            return Implementation.updateAsync(sobject);
        }

        public static List<SaveResult> updateImmediate(List<SObject> sobjects)
        {
            return Implementation.updateImmediate(sobjects);
        }

        public static SaveResult updateImmediate(SObject sobject)
        {
            return Implementation.updateImmediate(sobject);
        }

        public static LeadConvertResult convertLead(LeadConvert leadConvert, DMLOptions DmlOptions)
        {
            return Implementation.convertLead(leadConvert, DmlOptions);
        }

        public static LeadConvertResult convertLead(LeadConvert leadConvert)
        {
            return Implementation.convertLead(leadConvert);
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts, bool allOrNothing)
        {
            return Implementation.convertLead(leadConverts, allOrNothing);
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts, DMLOptions DmlOptions)
        {
            return Implementation.convertLead(leadConverts, DmlOptions);
        }

        public static List<LeadConvertResult> convertLead(List<LeadConvert> leadConverts)
        {
            return Implementation.convertLead(leadConverts);
        }

        public static DeleteResult delete(ID id)
        {
            return Implementation.delete(id);
        }

        public static List<DeleteResult> delete(List<ID> ids, bool allOrNothing)
        {
            return Implementation.delete(ids, allOrNothing);
        }

        public static List<DeleteResult> delete(List<ID> ids)
        {
            return Implementation.delete(ids);
        }

        public static DeleteResult delete(SObject sobject)
        {
            return Implementation.delete(sobject);
        }

        public static List<EmptyRecycleBinResult> emptyRecycleBin(List<ID> ids)
        {
            return Implementation.emptyRecycleBin(ids);
        }

        public static string executeBatch(Batchable batchable, int batchSize)
        {
            return Implementation.executeBatch(batchable, batchSize);
        }

        public static string executeBatch(Batchable batchable)
        {
            return Implementation.executeBatch(batchable);
        }

        public static QueryLocator getQueryLocator(List<SObject> query)
        {
            return Implementation.getQueryLocator(query);
        }

        public static List<SaveResult> insert(List<SObject> sobjects, bool allOrNothing)
        {
            return Implementation.insert(sobjects, allOrNothing);
        }

        public static List<SaveResult> insert(List<SObject> sobjects, DMLOptions DmlOptions)
        {
            return Implementation.insert(sobjects, DmlOptions);
        }

        public static List<SaveResult> insert(List<SObject> sobjects)
        {
            return Implementation.insert(sobjects);
        }

        public static SaveResult insert(SObject sobject)
        {
            return Implementation.insert(sobject);
        }

        public static List<SaveResult> insertAsync(List<SObject> sobjects, AsyncInsertCallback callback)
        {
            return Implementation.insertAsync(sobjects, callback);
        }

        public static SaveResult insertAsync(SObject sobject, AsyncInsertCallback callback)
        {
            return Implementation.insertAsync(sobject, callback);
        }

        public static UndeleteResult undelete(ID id)
        {
            return Implementation.undelete(id);
        }

        public static List<UndeleteResult> undelete(List<ID> ids, bool allOrNothing)
        {
            return Implementation.undelete(ids, allOrNothing);
        }

        public static List<UndeleteResult> undelete(List<ID> ids)
        {
            return Implementation.undelete(ids);
        }

        public static UndeleteResult undelete(SObject sobject)
        {
            return Implementation.undelete(sobject);
        }

        public static List<SaveResult> update(List<SObject> sobjects, bool allOrNothing)
        {
            return Implementation.update(sobjects, allOrNothing);
        }

        public static List<SaveResult> update(List<SObject> sobjects)
        {
            return Implementation.update(sobjects);
        }

        public static SaveResult update(SObject sobject)
        {
            return Implementation.update(sobject);
        }

        public static List<SaveResult> updateAsync(List<SObject> sobjects, AsyncUpdateCallback callback)
        {
            return Implementation.updateAsync(sobjects, callback);
        }

        public static SaveResult updateAsync(SObject sobject, AsyncUpdateCallback callback)
        {
            return Implementation.updateAsync(sobject, callback);
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects, bool allOrNothing)
        {
            return Implementation.upsert(sobjects, allOrNothing);
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects, SObjectField field, bool allOrNothing)
        {
            return Implementation.upsert(sobjects, field, allOrNothing);
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects, SObjectField field)
        {
            return Implementation.upsert(sobjects, field);
        }

        public static List<UpsertResult> upsert(List<SObject> sobjects)
        {
            return Implementation.upsert(sobjects);
        }

        public static UpsertResult upsert(SObject sobject, bool allOrNothing)
        {
            return Implementation.upsert(sobject, allOrNothing);
        }

        public static UpsertResult upsert(SObject sobject, SObjectField field)
        {
            return Implementation.upsert(sobject, field);
        }

        public static UpsertResult upsert(SObject sobject)
        {
            return Implementation.upsert(sobject);
        }
    }
}
