namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;
    using LockResult = global::Apex.Approval.LockResult;
    using ProcessRequest = global::Apex.Approval.ProcessRequest;
    using ProcessResult = global::Apex.Approval.ProcessResult;
    using UnlockResult = global::Apex.Approval.UnlockResult;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_approval.htm#apex_methods_system_approval
    /// </summary>
    public class Approval
    {
        // infrastructure
        public Approval(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Approval));
            }
        }

        // API
        public static bool isLocked(ID id)
        {
            return Implementation.isLocked(id);
        }

        public static Map<ID, bool> isLocked(List<ID> ids)
        {
            return Implementation.isLocked(ids);
        }

        public static bool isLocked(SObject sobject)
        {
            return Implementation.isLocked(sobject);
        }

        public static LockResult @lock(ID recordId)
        {
            return Implementation.@lock(recordId);
        }

        public static List<LockResult> @lock(List<ID> ids)
        {
            return Implementation.@lock(ids);
        }

        public static LockResult @lock(SObject recordToLock)
        {
            return Implementation.@lock(recordToLock);
        }

        public static LockResult @lock(ID recordId, bool allOrNothing)
        {
            return Implementation.@lock(recordId, allOrNothing);
        }

        public static List<LockResult> @lock(List<ID> recordIds, bool allOrNothing)
        {
            return Implementation.@lock(recordIds, allOrNothing);
        }

        public static LockResult @lock(SObject recordToLock, bool allOrNothing)
        {
            return Implementation.@lock(recordToLock, allOrNothing);
        }

        public static ProcessResult process(ProcessRequest approvalRequest)
        {
            return Implementation.process(approvalRequest);
        }

        public static ProcessResult process(ProcessRequest approvalRequests, bool allOrNone)
        {
            return Implementation.process(approvalRequests, allOrNone);
        }

        public static UnlockResult unlock(ID recordId)
        {
            return Implementation.unlock(recordId);
        }

        public static List<UnlockResult> unlock(List<ID> recordIds)
        {
            return Implementation.unlock(recordIds);
        }

        public static UnlockResult unlock(SObject recordToUnlock)
        {
            return Implementation.unlock(recordToUnlock);
        }

        public static UnlockResult unlock(ID recordId, bool allOrNothing)
        {
            return Implementation.unlock(recordId, allOrNothing);
        }

        public static List<UnlockResult> unlock(List<ID> recordIds, bool allOrNothing)
        {
            return Implementation.unlock(recordIds, allOrNothing);
        }

        public static UnlockResult unlock(SObject recordToUnlock, bool allOrNothing)
        {
            return Implementation.unlock(recordToUnlock, allOrNothing);
        }
    }
}
