using AdvanceDemo;
using Apex;

namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using ApexParser;
    using ApexSharpApi;

    public class Program
    {
        // Location of your APEX and C# Files that we will be converting
        public static DirectoryInfo apexLocation = new DirectoryInfo(@"/ApexSharp/SalesForce/src/classes/");
        public static DirectoryInfo cSharpLocation = new DirectoryInfo(@"/ApexSharp/Advance/Demo/CSharpClasses/");
        public static void Main(string[] args)
        {
            // Start Logging
            Logging.EnableLogging();

            // Always Initialize your settings when ever you are connecting to SF
            Setup.Init();


            // Keep Track of the API Limits
            Console.WriteLine(Limits.GetApiLimits().DailyApiRequests.Remaining);

            // Create Offline classes for SObjects
            // CreateOffLineClasses();

            // ConvertToCSharp();
            // CSharpClasses.RunAll.TestClassess();
            // ConvertToApex();

            // Keep Track of the API Limits
            Console.WriteLine(Limits.GetApiLimits().DailyApiRequests.Remaining);

            Console.WriteLine("Done");

            // Flush and Close
            Logging.CloseLogging();
        }

        public static void CreateOffLineClasses()
        {
            try
            {
                ModelGen modelGen = new ModelGen();

                // If you want to create offline classes for all the objects
                // var allObjects = modelGen.GetAllObjectNames().ToList();
                /// modelGen.CreateOfflineSymbolTable(allObjects);

                // To save time we will only create objects we are going to work with
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
            // Convert APEX to C#
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
            // Convert to C# to Apex
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
