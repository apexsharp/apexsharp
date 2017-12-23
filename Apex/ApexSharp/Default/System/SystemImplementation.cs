using Apex.ApexSharp.Implementation;
using Apex.ConnectApi;
using Apex.Database;
using Apex.System;
using static System.Console;
using DateTime = System.DateTime;
using IDisposable = System.IDisposable;
using NUnitAssert = NUnit.Framework.Assert;

namespace Apex.ApexSharp.Default.System
{
    [Implements(typeof(global::Apex.System.System))]
    public class SystemImplementation
    {
        // Self

        public class SystemInstance : IDisposable
        {
            public void Dispose()
            {
            }
        }

        // Implementation

        private dynamic NotImplemented { get; } = new StubImplementation(typeof(global::Apex.System.System));

        public void abortJob(string jobId) => NotImplemented.abortJob(jobId);

        public void assert(bool condition) =>
            NUnitAssert.True(condition);

        public void assert(bool condition, object msg) =>
            NUnitAssert.True(condition, "{0}", msg);

        public void assertEquals(object expected, object actual) =>
            NUnitAssert.AreEqual(expected, actual);

        public void assertEquals(object expected, object actual, object msg) =>
            NUnitAssert.AreEqual(expected, actual, "{0}", msg);

        public void assertNotEquals(object expected, object actual) =>
            NUnitAssert.AreNotEqual(expected, actual);

        public void assertNotEquals(object expected, object actual, object msg) =>
            NUnitAssert.AreNotEqual(expected, actual, "{0}", msg);

        public void changeProtection(string apiName, string typeApiName, string protection) =>
            NotImplemented.changeProtection(apiName, typeApiName, protection);

        public bool checkPackageBooleanValue(string apiName) =>
            NotImplemented.checkPackageBooleanValue(apiName);

        public Date checkPackageDateValue(string apiName) =>
            NotImplemented.checkPackageDateValue(apiName);

        public int checkPackageIntegerValue(string apiName) =>
            NotImplemented.checkPackageIntegerValue(apiName);

        public bool checkPermission(string apiName) =>
            NotImplemented.checkPermission(apiName);

        public PageReference currentPageReference() =>
            NotImplemented.currentPageReference();

        public long currentTimeMillis()
        {
            var now = DateTime.Now;
            var epoch = new DateTime(1970, 1, 1);
            var millis = (now - epoch).TotalMilliseconds;
            return (long)millis;
        }

        public void debug(object msg) => WriteLine(msg);

        public void debug(LoggingLevel logLevel, object msg) => WriteLine(msg);

        public ID enqueueJob(object queueableObj) => NotImplemented.enqueueJob(queueableObj);

        public bool equals(object obj1, object obj2) => Equals(obj1, obj2);

        public ApplicationReadWriteMode getApplicationReadWriteMode() =>
            NotImplemented.getApplicationReadWriteMode();

        public int hashCode(object obj) => obj?.GetHashCode() ?? 0;

        public bool isBatch() => NotImplemented.isBatch();

        public bool isFuture() => NotImplemented.isFuture(); // isn't it the future yet?

        public bool isQueueable() => NotImplemented.isQueueable();

        public bool isScheduled() => NotImplemented.isScheduled();

        public void movePassword(ID targetUserId, ID sourceUserId) =>
            NotImplemented.movePassword(targetUserId, sourceUserId);

        public Datetime now() => Datetime.now();

        public List<ID> process(List<ID> workItemIds, string action, string comments, string nextApprover) =>
            NotImplemented.process(workItemIds, action, comments, nextApprover);

        public int purgeOldAsyncJobs(Date dt) => NotImplemented.purgeOldAsyncJobs(dt);

        public Version requestVersion() => NotImplemented.requestVersion();

        public ResetPasswordResult resetPassword(ID userId, bool sendUserEmail) =>
            NotImplemented.resetPassword(userId, sendUserEmail);

        public IDisposable runAs(Version version) => new SystemInstance();

        public IDisposable runAs(User userSObject) => new SystemInstance();

        public IDisposable runAs(SObject userSObject) => new SystemInstance();

        public IDisposable runAs(SObject user, object block) => new SystemInstance();

        public string schedule(string jobName, string cronExpression, object schedulableClass) =>
            NotImplemented.schedule(jobName, cronExpression, schedulableClass);

        public string scheduleBatch(Batchable batchable, string jobName, int minutesFromNow) =>
            NotImplemented.scheduleBatch(batchable, jobName, minutesFromNow);

        public string scheduleBatch(Batchable batchable, string jobName, int minutesFromNow, int scopeSize) =>
            NotImplemented.scheduleBatch(batchable, jobName, minutesFromNow, scopeSize);

        public void setPackageBooleanValue(string apiName, bool value) =>
            NotImplemented.setPackageBooleanValue(apiName, value);

        public void setPackageDateValue(string apiName, Date value) =>
            NotImplemented.setPackageDateValue(apiName, value);

        public void setPackageIntegerValue(string apiName, int value) =>
            NotImplemented.setPackageBooleanValue(apiName, value);

        public void setPassword(ID userId, string password) =>
            NotImplemented.setPassword(userId, password);

        public List<ID> submit(List<ID> workItemIds, string comments, string nextApprover) =>
            NotImplemented.submit(workItemIds, comments, nextApprover);

        public Date today() => Date.today();

        public void changeOwnPassword(string oldPassword, string newPassword) =>
            NotImplemented.changeOwnPassword(oldPassword, newPassword);

        public ResetPasswordResult resetPasswordWithEmailTemplate(ID userId, bool sendUserEmail, string emailTemplateName) =>
            NotImplemented.resetPasswordWithEmailTemplate(userId, sendUserEmail, emailTemplateName);

        public string schedule(string jobName, string cronExp, Schedulable schedulable) =>
            NotImplemented.schedule(jobName, cronExp, schedulable);
    }
}
