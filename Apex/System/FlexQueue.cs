namespace Apex.System
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using ApexSharpApi.ApexApi;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_class_System_FlexQueue.htm#apex_class_System_FlexQueue
    /// </summary>
    public class FlexQueue
    {
        // infrastructure
        public FlexQueue(dynamic self)
        {
            Self = self;
        }

        dynamic Self { get; set; }

        static dynamic Implementation
        {
            get
            {
                return Implementor.GetImplementation(typeof(FlexQueue));
            }
        }

        // API
        public static bool moveAfterJob(ID jobToMoveId, ID jobInQueueId)
        {
            return Implementation.moveAfterJob(jobToMoveId, jobInQueueId);
        }

        public static bool moveBeforeJob(ID jobToMoveId, ID jobInQueueId)
        {
            return Implementation.moveBeforeJob(jobToMoveId, jobInQueueId);
        }

        public static bool moveJobToEnd(ID jobId)
        {
            return Implementation.moveJobToEnd(jobId);
        }

        public static bool moveJobToFront(ID jobId)
        {
            return Implementation.moveJobToFront(jobId);
        }
    }
}
