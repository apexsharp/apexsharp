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
            File.Delete(@"/home/osboxes/apexsharp/config.json");

            try
            {
                // See if we have an existing connection
                ConnectionUtil.Session = ConnectionUtil.GetSession(@"/home/osboxes/apexsharp/config.json");
            }
            // Else Create a new session
            catch (SalesForceNoFileFoundException)
            {
                string vSprojectocation = Path.GetFullPath(@"/home/osboxes/apexsharp/Demo/");
                try
                {
                    // This example assumes you cloned your GIT repo to the root level.
                    ConnectionUtil.Session = new ApexSharp().
                         SalesForceUrl("https://login.salesforce.com/")
                        .AndSalesForceApiVersion(40)

                        
                        .WithUserId("apexsharpdx@jayonsoftware.com")
                        .AndPassword("JugCnkhExxMWuVvLWN8wccEM")
                        .AndToken("jiiZsAh3L0zP0KPw6iJqdqGd")


                        .SalesForceLocation(@"/home/sboxes/apexsharp/SalesForce/src/")
                        .VsProjectLocation(vSprojectocation)
                        .SaveConfigAt(@"/home/osboxes/apexsharp/config.json")
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
