using ApexSharpApi.ApexApi;
using Action = System.Action;
using IDisposable = System.IDisposable;
using NUnitAssert = NUnit.Framework.Assert;

namespace Apex.System
{
    public class System : IDisposable
    {
        public static System runAs(SObject user)
        {
            return new System();
        }


        public void Dispose()
        {

        }

        public static void abortJob(string jobId)
        {
            throw new global::System.NotImplementedException("System.AbortJob");
        }

        public static void assert(bool condition)
        {
            NUnitAssert.True(condition);
        }

        public static void assert(bool condition, object msg)
        {
            ////throw new global::System.NotImplementedException("System.Assert : Use NUnit Asserts");
            NUnitAssert.True(condition, "{0}", msg);
        }

        public static void assertEquals(object expected, object actual)
        {
            ////throw new global::System.NotImplementedException("System.AssertEquals : Use NUnit Asserts");
            NUnitAssert.AreEqual(expected, actual);
        }

        public static void assertEquals(object expected, object actual, object msg)
        {
            ////throw new global::System.NotImplementedException("System.AssertEquals : Use NUnit Asserts");
            NUnitAssert.AreEqual(expected, actual, "{0}", msg);
        }

        public static void assertNotEquals(object expected, object actual)
        {
            ////throw new global::System.NotImplementedException("System.AssertNotEquals : Use NUnit Asserts");
            NUnitAssert.AreNotEqual(expected, actual);
        }

        public static void assertNotEquals(object expected, object actual, object msg)
        {
            ////throw new global::System.NotImplementedException("System.AssertNotEquals : Use NUnit Asserts");
            NUnitAssert.AreNotEqual(expected, actual, "{0}", msg);
        }

        public static void changeProtection(string apiName, string typeApiName, string protection)
        {
            throw new global::System.NotImplementedException("System.ChangeProtection");
        }

        public static bool checkPackageBooleanValue(string apiName)
        {
            throw new global::System.NotImplementedException("System.CheckPackageBooleanValue");
        }

        public static Date checkPackageDateValue(string apiName)
        {
            throw new global::System.NotImplementedException("System.CheckPackageDateValue");
        }

        public static int checkPackageIntegerValue(string apiName)
        {
            throw new global::System.NotImplementedException("System.CheckPackageIntegerValue");
        }

        public static bool checkPermission(string apiName)
        {
            throw new global::System.NotImplementedException("System.CheckPermission");
        }

        public static PageReference currentPageReference()
        {
            throw new global::System.NotImplementedException("System.CurrentPageReference");
        }

        public static long currentTimeMillis()
        {
            throw new global::System.NotImplementedException("System.CurrentTimeMillis");
        }

        public static void debug(object o)
        {
            global::System.Console.WriteLine(o);
        }

        public static void debug(object logLevel, object o)
        {
            global::System.Console.WriteLine(o);
        }

        public static ID enqueueJob(object queueable)
        {
            throw new global::System.NotImplementedException("System.EnqueueJob");
        }

        public static bool equals(object left, object right)
        {
            throw new global::System.NotImplementedException("System.Equals");
        }

        //public static ApplicationReadWriteMode GetApplicationReadWriteMode(){throw new global::System.NotImplementedException("System.GetApplicationReadWriteMode");}
        public static int hashCode(object obj)
        {
            throw new global::System.NotImplementedException("System.HashCode");
        }

        public static bool isBatch()
        {
            throw new global::System.NotImplementedException("System.IsBatch");
        }

        public static bool isFuture()
        {
            throw new global::System.NotImplementedException("System.IsFuture");
        }

        public static bool isQueueable()
        {
            throw new global::System.NotImplementedException("System.IsQueueable");
        }

        public static bool isScheduled()
        {
            throw new global::System.NotImplementedException("System.IsScheduled");
        }

        public static void movePassword(ID targetUserId, ID sourceUserId)
        {
            throw new global::System.NotImplementedException("System.MovePassword");
        }

        public static DateTime now()
        {
            throw new global::System.NotImplementedException("System.Now");
        }

        public static List<ID> process(List<ID> workitemIds, string action, string commments, string nextApprover)
        {
            throw new global::System.NotImplementedException("System.Process");
        }

        public static int purgeOldAsyncJobs(Date date)
        {
            throw new global::System.NotImplementedException("System.PurgeOldAsyncJobs");
        }

        public static Version requestVersion()
        {
            throw new global::System.NotImplementedException("System.RequestVersion");
        }

        public static ResetPasswordResult resetPassword(ID userId, bool sendUserEmail)
        {
            throw new global::System.NotImplementedException("System.ResetPassword");
        }

        public static void runAs(Package.Version version)
        {
            throw new global::System.NotImplementedException("System.RunAs");
        }

        public static void runAs(SObject user, object block)
        {
            throw new global::System.NotImplementedException("System.RunAs");
        }

        public static string schedule(string jobName, string cronExp, object schedulable)
        {
            throw new global::System.NotImplementedException("System.Schedule");
        }

        public static string scheduleBatch(object batchable, string jobName, int minutesFromNow)
        {
            throw new global::System.NotImplementedException("System.ScheduleBatch");
        }

        public static string scheduleBatch(object batchable, string jobName, int minutesFromNow, int scopeSize)
        {
            throw new global::System.NotImplementedException("System.ScheduleBatch");
        }

        public static void setPackageBooleanValue(string apiName, bool value)
        {
            throw new global::System.NotImplementedException("System.SetPackageBooleanValue");
        }

        public static void setPackageDateValue(string apiName, Date value)
        {
            throw new global::System.NotImplementedException("System.SetPackageDateValue");
        }

        public static void setPackageIntegerValue(string apiName, int value)
        {
            throw new global::System.NotImplementedException("System.SetPackageIntegerValue");
        }

        public static void setPassword(ID userId, string password)
        {
            throw new global::System.NotImplementedException("System.SetPassword");
        }

        public static List<ID> submit(List<ID> ids, string commments, string nextApprover)
        {
            throw new global::System.NotImplementedException("System.Submit");
        }

        public static Date today()
        {
            throw new global::System.NotImplementedException("System.Today");
        }
    }
}