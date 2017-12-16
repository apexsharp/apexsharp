namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.ConnectApi;
    using global::Apex.Database;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_system.htm#apex_methods_system_system
    /// </summary>
    public class System
    {
        // infrastructure
        public System(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(System));
            }
        }

        // API
        public static void abortJob(string jobId)
        {
            Implementation.abortJob(jobId);
        }

        public static void assert(bool condition, object msg)
        {
            Implementation.assert(condition, msg);
        }

        public static void assertEquals(object expected, object actual, object msg)
        {
            Implementation.assertEquals(expected, actual, msg);
        }

        public static void assertNotEquals(object expected, object actual, object msg)
        {
            Implementation.assertNotEquals(expected, actual, msg);
        }

        public static PageReference currentPageReference()
        {
            return Implementation.currentPageReference();
        }

        public static long currentTimeMillis()
        {
            return Implementation.currentTimeMillis();
        }

        public static void debug(object msg)
        {
            Implementation.debug(msg);
        }

        public static void debug(LoggingLevel logLevel, object msg)
        {
            Implementation.debug(logLevel, msg);
        }

        public static ID enqueueJob(object queueableObj)
        {
            return Implementation.enqueueJob(queueableObj);
        }

        public static bool equals(object obj1, object obj2)
        {
            return Implementation.equals(obj1, obj2);
        }

        public static ApplicationReadWriteMode getApplicationReadWriteMode()
        {
            return Implementation.getApplicationReadWriteMode();
        }

        public static int hashCode(object obj)
        {
            return Implementation.hashCode(obj);
        }

        public static bool isBatch()
        {
            return Implementation.isBatch();
        }

        public static bool isFuture()
        {
            return Implementation.isFuture();
        }

        public static bool isQueueable()
        {
            return Implementation.isQueueable();
        }

        public static bool isScheduled()
        {
            return Implementation.isScheduled();
        }

        public static void movePassword(ID targetUserId, ID sourceUserId)
        {
            Implementation.movePassword(targetUserId, sourceUserId);
        }

        public static Datetime now()
        {
            return Implementation.now();
        }

        public static List<ID> process(List<ID> workItemIds, string action, string comments, string nextApprover)
        {
            return Implementation.process(workItemIds, action, comments, nextApprover);
        }

        public static int purgeOldAsyncJobs(Date dt)
        {
            return Implementation.purgeOldAsyncJobs(dt);
        }

        public static Version requestVersion()
        {
            return Implementation.requestVersion();
        }

        public static ResetPasswordResult resetPassword(ID userId, bool sendUserEmail)
        {
            return Implementation.resetPassword(userId, sendUserEmail);
        }

        public static void runAs(Version version)
        {
            Implementation.runAs(version);
        }

        public static void runAs(User userSObject)
        {
            Implementation.runAs(userSObject);
        }

        public static string schedule(string jobName, string cronExpression, object schedulableClass)
        {
            return Implementation.schedule(jobName, cronExpression, schedulableClass);
        }

        public static string scheduleBatch(Batchable batchable, string jobName, int minutesFromNow)
        {
            return Implementation.scheduleBatch(batchable, jobName, minutesFromNow);
        }

        public static string scheduleBatch(Batchable batchable, string jobName, int minutesFromNow, int scopeSize)
        {
            return Implementation.scheduleBatch(batchable, jobName, minutesFromNow, scopeSize);
        }

        public static void setPassword(ID userId, string password)
        {
            Implementation.setPassword(userId, password);
        }

        public static List<ID> submit(List<ID> workItemIds, string comments, string nextApprover)
        {
            return Implementation.submit(workItemIds, comments, nextApprover);
        }

        public static Date today()
        {
            return Implementation.today();
        }

        public static void assert(bool condition)
        {
            Implementation.assert(condition);
        }

        public static void assertEquals(object expected, object actual)
        {
            Implementation.assertEquals(expected, actual);
        }

        public static void assertNotEquals(object expected, object actual)
        {
            Implementation.assertNotEquals(expected, actual);
        }

        public static void changeOwnPassword(string oldPassword, string newPassword)
        {
            Implementation.changeOwnPassword(oldPassword, newPassword);
        }

        public static ResetPasswordResult resetPasswordWithEmailTemplate(ID userId, bool sendUserEmail, string emailTemplateName)
        {
            return Implementation.resetPasswordWithEmailTemplate(userId, sendUserEmail, emailTemplateName);
        }

        public static void runAs(SObject user, object block)
        {
            Implementation.runAs(user, block);
        }

        public static string schedule(string jobName, string cronExp, Schedulable schedulable)
        {
            return Implementation.schedule(jobName, cronExp, schedulable);
        }
    }
}
