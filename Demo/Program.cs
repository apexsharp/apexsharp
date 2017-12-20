

namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using ApexParser;
    using ApexSharpApi;
    using Apex;
    using CSharpClasses;

    public class Program
    {

        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            // Location of your APEX and C# Files that we will be converting
            DirectoryInfo apexLocation = new DirectoryInfo(@"/ApexSharp/SalesForce/src/classes/");
            DirectoryInfo cSharpLocation = new DirectoryInfo(@"/ApexSharp/Demo/CSharpClasses/");

            // Start Logging
            Setup.StartLogging();

            // Always Initialize your settings when ever you are connecting to SF
            Setup.Init();

            // Keep Track of the API Limits
            Console.WriteLine($"Api Request Remaining {Limits.GetApiLimits().DailyApiRequests.Remaining}");

            // Create Offline classes for SObjects
            // CreateOffLineClasses();

            CodeConverter.ConvertToCSharp(apexLocation, cSharpLocation, "Demo.CSharpClasses");
         
            //DmlTest.UpsertTest();

            // CodeConverter.ConvertToApex(cSharpLocation, apexLocation, 40);

            // Keep Track of the API Limits
            Console.WriteLine($"Api Request Remaining {Limits.GetApiLimits().DailyApiRequests.Remaining}");

            // Flush and Close
            Setup.StopLogging();

            Console.WriteLine("Done, Press Any Key To Exit");
            Console.ReadLine();
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


    }
}
