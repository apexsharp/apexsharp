using System;
using System.IO;
using ApexSharpApi;

namespace AdvanceDemo
{
    public class Setup
    {
        public static bool Init()
        { 
            // Due to different OS and how they manage file paths, its best to to use the Path.GetFullPath Method.
            // This example assumes you cloned your GIT repo to the root level.
            // SessionLocation is where your SF session will be Saved
            var sessionLocation = Path.GetFullPath(@"/apexsharp/advanceConfig.json");
            // SalesForceLocation is the location of your Salesofrce project
            var salesForceLocation = Path.GetFullPath(@"/apexsharp/SalesForce/src/");
            // VsProjectLocation is the location of your Visual Studio Project
            var vSprojectocation = Path.GetFullPath(@"/apexsharp/AdvanceDemo/");

            try
            {
                // See if we have an existing connection use it.
                ConnectionUtil.Session = ConnectionUtil.GetSession(sessionLocation);
            }
            // Else Create a new session
            catch (SalesForceNoFileFoundException)
            {
                try
                {
                    
                    ConnectionUtil.Session = new ApexSharp().
                         SalesForceUrl("https://login.salesforce.com/")
                        .AndSalesForceApiVersion(40)
                        
                        .WithUserId("apexsharpdx@jayonsoftware.com")
                        .AndPassword("JugCnkhExxMWuVvLWN8wccEM")
                        .AndToken("jiiZsAh3L0zP0KPw6iJqdqGd")

                        .SalesForceLocation(salesForceLocation)
                        .VsProjectLocation(vSprojectocation)
                        .SaveConfigAt(sessionLocation)
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
