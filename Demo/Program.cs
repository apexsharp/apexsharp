using System.Linq;

namespace Demo
{
    using Apex;
    using ApexSharpApi;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            Start();

            Console.WriteLine("Done, Press Any Key To Exit");
            // Console.ReadLine();
        }

        public static void Start()
        {
            // Always Initialize your settings
            Setup.InitializeSession();

            // Keep Track of the API Limits
            Console.WriteLine($"Api Request Remaining {Limits.GetApiLimits().DailyApiRequests.Remaining}");

            // Create Offline classes for SObjects
            // CreateOffLineClasses();

            try
            {
                // Location of your APEX and C# Files that we will be converting
                DirectoryInfo apexLocation = new DirectoryInfo(@"../SalesForce/src/classes/");
                DirectoryInfo cSharpLocation = new DirectoryInfo(@"../Demo/CSharpClasses/");

                // Convert Apex to C#
                // CodeConverter.ConvertToCSharp(apexLocation, cSharpLocation, "Demo.CSharpClasses");

                // Convert C# to APEX
                // CodeConverter.ConvertToApex(cSharpLocation, apexLocation, 40);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            CSharpClasses.DmlTest.UpsertTest();

            // Keep Track of the API Limits
            Console.WriteLine($"Api Request Remaining {Limits.GetApiLimits().DailyApiRequests.Remaining}");

            // Flush and Close
            Setup.StopLogging();
        }

        // Create Offline DTO for all the Salesforce Objects
        public static void CreateAllOffLineClasses()
        {
            try
            {
                ModelGen modelGen = new ModelGen();
                modelGen.CreateOfflineSymbolTable(modelGen.GetAllObjectNames().ToList(), "Demo.SObjects");
            }
            catch (ApexSharpHttpException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        // Create Offline DTO for a set of Salesforce objects
        public static void CreateOffLineClasses()
        {
            try
            {
                ModelGen modelGen = new ModelGen();

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

                modelGen.CreateOfflineSymbolTable(onlyObjects, "Demo.SObjects");
            }
            catch (ApexSharpHttpException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public static void MokDemo()
        {
            // Call the Default Implementaiton
            Console.WriteLine("Using Real Implementation");
            Console.WriteLine();

            DemoApexClass demo = new DemoApexClass("Mickey Mouse", 80);
            Console.WriteLine("Name = {0}", demo.Name);
            Console.WriteLine("Age = {0}", demo.Age);

            Console.WriteLine(demo.NonStaticMethod());

            DemoApexClass.StaticMethod("Hello");
            DemoApexClass.AnotherStaticMethod("apexSharp");
            DemoApexClass.StaticMethodWithMokAndReal("apexsharpMok");


            Console.WriteLine();
            Console.WriteLine("Using Mok Implementation");
            Console.WriteLine();

            MokSetup.InitMok();

            DemoApexClass mok = new DemoApexClass("Mickey Mouse", 80);
            Console.WriteLine("Name = {0}", mok.Name);
            Console.WriteLine("Age = {0}", mok.Age);

            Console.WriteLine(mok.NonStaticMethod());


            DemoApexClass.StaticMethod("ApexSharp");

            try
            {
                DemoApexClass.StaticMethodWithMokAndReal("apexSharpMok");
                DemoApexClass.AnotherStaticMethod("apexSharp");
                // This line falls back to the default implementation
                DemoApexClass.StaticMethodWithMokAndReal("apexSharp");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not implemented: {0}", ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Done, Press any key to exit");
            Console.ReadKey();
        }
    }
}
