namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.QuickAction;
    using global::Apex.Schema;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_methods_system_test.htm#apex_methods_system_test
    /// </summary>
    public class Test
    {
        // infrastructure
        public Test(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(Test));
            }
        }

        // API
        public static object createStub(Type parentType, StubProvider stubProvider)
        {
            return Implementation.createStub(parentType, stubProvider);
        }

        public static List<ID> enqueueBatchJobs(int numberOfJobs)
        {
            return Implementation.enqueueBatchJobs(numberOfJobs);
        }

        public static List<ID> getFlexQueueOrder()
        {
            return Implementation.getFlexQueueOrder();
        }

        public static ID getStandardPricebookId()
        {
            return Implementation.getStandardPricebookId();
        }

        public static object invokeContinuationMethod(object controller, Continuation request)
        {
            return Implementation.invokeContinuationMethod(controller, request);
        }

        public static bool isRunningTest()
        {
            return Implementation.isRunningTest();
        }

        public static List<SObject> loadData(SObjectType sObjectToken, string resourceName)
        {
            return Implementation.loadData(sObjectToken, resourceName);
        }

        public static SendEmailQuickActionDefaults newSendEmailQuickActionDefaults(ID contextId, ID replyToId)
        {
            return Implementation.newSendEmailQuickActionDefaults(contextId, replyToId);
        }

        public static void setContinuationResponse(string requestLabel, HttpResponse mockResponse)
        {
            Implementation.setContinuationResponse(requestLabel, mockResponse);
        }

        public static void setCreatedDate(ID recordId, Datetime createdDatetime)
        {
            Implementation.setCreatedDate(recordId, createdDatetime);
        }

        public static void setCurrentPage(PageReference page)
        {
            Implementation.setCurrentPage(page);
        }

        public static void setCurrentPageReference(PageReference page)
        {
            Implementation.setCurrentPageReference(page);
        }

        public static void setFixedSearchResults(ID[] fixedSearchResults)
        {
            Implementation.setFixedSearchResults(fixedSearchResults);
        }

        public static void setMock(Type interfaceType, object instance)
        {
            Implementation.setMock(interfaceType, instance);
        }

        public static void setReadOnlyApplicationMode(bool applicationMode)
        {
            Implementation.setReadOnlyApplicationMode(applicationMode);
        }

        public static void startTest()
        {
            Implementation.startTest();
        }

        public static void stopTest()
        {
            Implementation.stopTest();
        }

        public static void testInstall(InstallHandler installImplementation, Version version, bool isPush)
        {
            Implementation.testInstall(installImplementation, version, isPush);
        }

        public static void testUninstall(UninstallHandler uninstallImplementation)
        {
            Implementation.testUninstall(uninstallImplementation);
        }

        public Test()
        {
            Implementation.Constructor();
        }

        public object clone()
        {
            return Self.clone();
        }

        public static object invokePage(PageReference p)
        {
            return Implementation.invokePage(p);
        }

        public static void setCurrentPage(object pageReference)
        {
            Implementation.setCurrentPage(pageReference);
        }

        public static void setCurrentPageReference(object pageReference)
        {
            Implementation.setCurrentPageReference(pageReference);
        }

        public static void setFixedSearchResults(List<string> searchResultsIds)
        {
            Implementation.setFixedSearchResults(searchResultsIds);
        }

        public static void testInstall(InstallHandler script, Version version)
        {
            Implementation.testInstall(script, version);
        }

        public static void testSandboxPostCopyScript(SandboxPostCopy script, ID organizationId, ID sandboxId, string sandboxName)
        {
            Implementation.testSandboxPostCopyScript(script, organizationId, sandboxId, sandboxName);
        }
    }
}
