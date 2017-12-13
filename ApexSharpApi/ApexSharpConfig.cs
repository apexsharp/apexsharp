using System.IO;

namespace ApexSharpApi
{
    public class ApexSharpConfig
    {
        public string SalesForceUrl { get; set; }
        public string HttpProxy { get; set; }
        public string SalesForceUserId { get; set; }
        public string SalesForcePassword { get; set; }
        public string SalesForcePasswordToken { get; set; }
        public int SalesForceApiVersion { get; set; }
        public string SessionId { get; set; }
        public string RestUrl { get; set; }
        public string RestSessionId { get; set; }
        public string ConfigLocation { get; set; }
        public string VsProjectLocation { get; set; }
        public string SalesForceLocation { get; set; }
        public long SessionCreationDateTime { get; set; }
        public string VsProjectName { get; set; }
    }
}