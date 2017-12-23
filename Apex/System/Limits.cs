namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_limits.htm#apex_methods_system_limits
    /// </summary>
    public class Limits
    {
        // infrastructure
        public Limits(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Limits));
            }
        }

        // API
        public static int getAggregateQueries()
        {
            return Implementation.getAggregateQueries();
        }

        public static int getLimitAggregateQueries()
        {
            return Implementation.getLimitAggregateQueries();
        }

        public static int getAsyncCalls()
        {
            return Implementation.getAsyncCalls();
        }

        public static int getLimitAsyncCalls()
        {
            return Implementation.getLimitAsyncCalls();
        }

        public static int getCallouts()
        {
            return Implementation.getCallouts();
        }

        public static int getChildRelationshipsDescribes()
        {
            return Implementation.getChildRelationshipsDescribes();
        }

        public static int getLimitCallouts()
        {
            return Implementation.getLimitCallouts();
        }

        public static int getCpuTime()
        {
            return Implementation.getCpuTime();
        }

        public static int getLimitCpuTime()
        {
            return Implementation.getLimitCpuTime();
        }

        public static int getDMLRows()
        {
            return Implementation.getDMLRows();
        }

        public static int getLimitDMLRows()
        {
            return Implementation.getLimitDMLRows();
        }

        public static int getDMLStatements()
        {
            return Implementation.getDMLStatements();
        }

        public static int getLimitDMLStatements()
        {
            return Implementation.getLimitDMLStatements();
        }

        public static int getEmailInvocations()
        {
            return Implementation.getEmailInvocations();
        }

        public static int getLimitEmailInvocations()
        {
            return Implementation.getLimitEmailInvocations();
        }

        public static int getFindSimilarCalls()
        {
            return Implementation.getFindSimilarCalls();
        }

        public static int getLimitFindSimilarCalls()
        {
            return Implementation.getLimitFindSimilarCalls();
        }

        public static int getFutureCalls()
        {
            return Implementation.getFutureCalls();
        }

        public static int getLimitFutureCalls()
        {
            return Implementation.getLimitFutureCalls();
        }

        public static int getHeapSize()
        {
            return Implementation.getHeapSize();
        }

        public static int getLimitHeapSize()
        {
            return Implementation.getLimitHeapSize();
        }

        public static int getMobilePushApexCalls()
        {
            return Implementation.getMobilePushApexCalls();
        }

        public static int getLimitMobilePushApexCalls()
        {
            return Implementation.getLimitMobilePushApexCalls();
        }

        public static int getQueries()
        {
            return Implementation.getQueries();
        }

        public static int getLimitQueries()
        {
            return Implementation.getLimitQueries();
        }

        public static int getQueryLocatorRows()
        {
            return Implementation.getQueryLocatorRows();
        }

        public static int getLimitQueryLocatorRows()
        {
            return Implementation.getLimitQueryLocatorRows();
        }

        public static int getQueryRows()
        {
            return Implementation.getQueryRows();
        }

        public static int getLimitQueryRows()
        {
            return Implementation.getLimitQueryRows();
        }

        public static int getQueueableJobs()
        {
            return Implementation.getQueueableJobs();
        }

        public static int getLimitQueueableJobs()
        {
            return Implementation.getLimitQueueableJobs();
        }

        public static int getRunAs()
        {
            return Implementation.getRunAs();
        }

        public static int getLimitRunAs()
        {
            return Implementation.getLimitRunAs();
        }

        public static int getSavepointRollbacks()
        {
            return Implementation.getSavepointRollbacks();
        }

        public static int getLimitSavepointRollbacks()
        {
            return Implementation.getLimitSavepointRollbacks();
        }

        public static int getSavepoints()
        {
            return Implementation.getSavepoints();
        }

        public static int getLimitSavepoints()
        {
            return Implementation.getLimitSavepoints();
        }

        public static int getSoslQueries()
        {
            return Implementation.getSoslQueries();
        }

        public static int getLimitSoslQueries()
        {
            return Implementation.getLimitSoslQueries();
        }

        public static int getDatabaseTime()
        {
            return Implementation.getDatabaseTime();
        }

        public static int getDmlRows()
        {
            return Implementation.getDmlRows();
        }

        public static int getDmlStatements()
        {
            return Implementation.getDmlStatements();
        }

        public static int getFieldsDescribes()
        {
            return Implementation.getFieldsDescribes();
        }

        public static int getFieldSetsDescribes()
        {
            return Implementation.getFieldSetsDescribes();
        }

        public static int getLimitChildRelationshipsDescribes()
        {
            return Implementation.getLimitChildRelationshipsDescribes();
        }

        public static int getLimitDatabaseTime()
        {
            return Implementation.getLimitDatabaseTime();
        }

        public static int getLimitDmlRows()
        {
            return Implementation.getLimitDmlRows();
        }

        public static int getLimitDmlStatements()
        {
            return Implementation.getLimitDmlStatements();
        }

        public static int getLimitFieldsDescribes()
        {
            return Implementation.getLimitFieldsDescribes();
        }

        public static int getLimitFieldSetsDescribes()
        {
            return Implementation.getLimitFieldSetsDescribes();
        }

        public static int getLimitPicklistDescribes()
        {
            return Implementation.getLimitPicklistDescribes();
        }

        public static int getLimitRecordTypesDescribes()
        {
            return Implementation.getLimitRecordTypesDescribes();
        }

        public static int getLimitScriptStatements()
        {
            return Implementation.getLimitScriptStatements();
        }

        public static int getPicklistDescribes()
        {
            return Implementation.getPicklistDescribes();
        }

        public static int getRecordTypesDescribes()
        {
            return Implementation.getRecordTypesDescribes();
        }

        public static int getScriptStatements()
        {
            return Implementation.getScriptStatements();
        }
    }
}
