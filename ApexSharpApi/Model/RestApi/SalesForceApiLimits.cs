namespace ApexSharpApi.Model.RestApi
{
    public enum LimitType
    {
        Concurrentasyncgetreportinstances,
        Concurrentsyncreportruns,
        DailyApiRequests,
        Dailyasyncapexexecutions,
        Dailybulkapirequests,
        Dailydurablegenericstreamingapievents,
        Dailydurablestreamingapievents,
        Dailygenericstreamingapievents,
        Dailystreamingapievents,
        Dailyworkflowemails,
        Datastoragemb,
        Durablestreamingapiconcurrentclients,
        Filestoragemb,
        Hourlyasyncreportruns,
        Hourlydashboardrefreshes,
        Hourlydashboardresults,
        Hourlydashboardstatuses,
        Hourlyodatacallout,
        Hourlysyncreportruns,
        Hourlytimebasedworkflow,
        Massemail,
        Singleemail,
        Streamingapiconcurrentclients,
    }

    public class SalesForceApiLimits
    {
        public Concurrentasyncgetreportinstances ConcurrentAsyncGetReportInstances { get; set; }
        public Concurrentsyncreportruns ConcurrentSyncReportRuns { get; set; }
        public Dailyapirequests DailyApiRequests { get; set; }
        public Dailyasyncapexexecutions DailyAsyncApexExecutions { get; set; }
        public Dailybulkapirequests DailyBulkApiRequests { get; set; }
        public Dailydurablegenericstreamingapievents DailyDurableGenericStreamingApiEvents { get; set; }
        public Dailydurablestreamingapievents DailyDurableStreamingApiEvents { get; set; }
        public Dailygenericstreamingapievents DailyGenericStreamingApiEvents { get; set; }
        public Dailystreamingapievents DailyStreamingApiEvents { get; set; }
        public Dailyworkflowemails DailyWorkflowEmails { get; set; }
        public Datastoragemb DataStorageMB { get; set; }
        public Durablestreamingapiconcurrentclients DurableStreamingApiConcurrentClients { get; set; }
        public Filestoragemb FileStorageMB { get; set; }
        public Hourlyasyncreportruns HourlyAsyncReportRuns { get; set; }
        public Hourlydashboardrefreshes HourlyDashboardRefreshes { get; set; }
        public Hourlydashboardresults HourlyDashboardResults { get; set; }
        public Hourlydashboardstatuses HourlyDashboardStatuses { get; set; }
        public Hourlyodatacallout HourlyODataCallout { get; set; }
        public Hourlysyncreportruns HourlySyncReportRuns { get; set; }
        public Hourlytimebasedworkflow HourlyTimeBasedWorkflow { get; set; }
        public Massemail MassEmail { get; set; }
        public Singleemail SingleEmail { get; set; }
        public Streamingapiconcurrentclients StreamingApiConcurrentClients { get; set; }
    }

    public class Concurrentasyncgetreportinstances
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Concurrentsyncreportruns
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailyapirequests
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailyasyncapexexecutions
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailybulkapirequests
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailydurablegenericstreamingapievents
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailydurablestreamingapievents
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailygenericstreamingapievents
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailystreamingapievents
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Dailyworkflowemails
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Datastoragemb
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Durablestreamingapiconcurrentclients
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Filestoragemb
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlyasyncreportruns
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlydashboardrefreshes
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlydashboardresults
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlydashboardstatuses
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlyodatacallout
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlysyncreportruns
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Hourlytimebasedworkflow
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Massemail
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Singleemail
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }

    public class Streamingapiconcurrentclients
    {
        public int Max { get; set; }
        public int Remaining { get; set; }
    }
}