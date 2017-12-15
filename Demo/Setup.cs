namespace Demo
{
    using System;
    using System.IO;
    using ApexSharpApi;
    using Serilog;

    public class Setup
    {
        public static bool Init()
        { 
            File.Delete(@"\ApexSharp\config.json");

            try
            {
                // See if we have an existing connection
                ConnectionUtil.Session = ConnectionUtil.GetSession(@"\ApexSharp\config.json");
            }
            // Else Create a new session
            catch (SalesForceNoFileFoundException)
            {
                try
                {
                    // This example assumes you cloned your GIT repo to the root level.
                    ConnectionUtil.Session = new ApexSharp().
                         SalesForceUrl("https://login.salesforce.com/")
                        .AndSalesForceApiVersion(40)
                        .WithUserId("User ID")
                        .AndPassword("Password")
                        .AndToken("Token")
                        .SalesForceLocation(@"\ApexSharp\SalesForce\src\")
                        .VsProjectLocation(@"\ApexSharp\Demo\")
                        .SaveConfigAt(@"\ApexSharp\config.json")
                        .CreateSession();
                }
                catch (SalesForceInvalidLoginException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
