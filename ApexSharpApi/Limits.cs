using ApexSharpApi.Model.RestApi;
using Newtonsoft.Json;

namespace ApexSharpApi
{
    public class Limits
    {
        public static int GetDailyApiLimit(LimitType limitType)
        {
            switch (limitType)
            {
                case LimitType.DailyApiRequests:
                    return GetApiLimits().DailyApiRequests.Max;
            }
            return 0;
        }

        public static int GetRemainingApiLimit(LimitType limitType)
        {
            switch (limitType)
            {
                case LimitType.DailyApiRequests:
                    return GetApiLimits().DailyApiRequests.Remaining;
            }
            return 0;
        }


        public static SalesForceApiLimits GetApiLimits()
        {
            HttpManager httpManager = new HttpManager();
            var json = httpManager.Get(@"limits/");
            SalesForceApiLimits apiLimits = JsonConvert.DeserializeObject<SalesForceApiLimits>(json,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return apiLimits;
        }
    }
}