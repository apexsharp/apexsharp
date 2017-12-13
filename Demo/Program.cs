namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ApexParser;
    using ApexSharpApi;

    public class Program
    {
        static void Main(string[] args)
        {

            // Always Initialize your settings when ever you are connecting to SF
            Setup.Init();

            // Keep Track of the API Limits
            Console.WriteLine(Limits.GetApiLimits().DailyApiRequests.Remaining);

            // Create Offline classes for SObjects
            // CreateOffLineClasses();

            // ConvertToCSharp();
            CSharpClasses.RunAll.TestClassess();
            // ConvertToApex();

            // Keep Track of the API Limits
            Console.WriteLine(Limits.GetApiLimits().DailyApiRequests.Remaining);

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        public static void CreateOffLineClasses()
        {
            try
            {
                ModelGen modelGen = new ModelGen();
                var allObjects = modelGen.GetAllObjectNames();

                List<string> onlyObjects = new List<string>
                {
                    "Contact",
                    "Account",
                    "User",
                    "UserRole",
                    "Profile",
                    "UserLicense",
                };

                modelGen.CreateOfflineSymbolTable(onlyObjects);
            }
            catch (ApexSharpHttpException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public static void ConvertToCSharp()
        {
            // Location of your APEX and C# Files that we will be converting
            DirectoryInfo apexLocation = new DirectoryInfo(@"\ApexSharp\SalesForce\src\classes\");
            DirectoryInfo cSharpLocation = new DirectoryInfo(@"\ApexSharp\Demo\CSharpClasses\");

            //// Convert APEX to C#
            if (apexLocation.Exists && cSharpLocation.Exists)
            {
                ApexSharpParser.ConvertToCSharp(apexLocation.FullName, cSharpLocation.FullName, "Demo.CSharpClasses");
            }
            else
            {
                Console.WriteLine("Missing Directory");
            }
        }

        public static void ConvertToApex()
        {
            // Location of your APEX and C# Files that we will be converting
            DirectoryInfo apexLocation = new DirectoryInfo(@"\ApexSharp\SalesForce\src\classes\");
            DirectoryInfo cSharpLocation = new DirectoryInfo(@"\ApexSharp\Demo\CSharpClasses\");

            //// Convert to C# to Apex
            if (apexLocation.Exists && cSharpLocation.Exists)
            {
                ApexSharpParser.ConvertToApex(cSharpLocation.FullName, apexLocation.FullName, 40);
            }
            else
            {
                Console.WriteLine("Missing Directory");
            }
        }
    }
}
