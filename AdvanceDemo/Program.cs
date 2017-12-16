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

            // MokDemo
            MokDemo();

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

        public static void MokDemo()
        {


            // Call the Default Implementaiton

            Console.WriteLine("Using Real Implementation");
            Console.WriteLine();

            DemoApexClass.AnotherStaticMethod("Hello");
            DemoApexClass.StaticMethod(1, "b");

            DemoApexClass userInfoReal = new DemoApexClass("Mickey Mouse", 80);
            Console.WriteLine("NonStaticMethod returns {0}", userInfoReal.NonStaticMethod());
            Console.WriteLine("Name = {0}", userInfoReal.Name);
            Console.WriteLine("Age = {0}", userInfoReal.Age);

            // Console.WriteLine();
            // Console.WriteLine("Mocking using ExpandoObject ");
            // Console.WriteLine();
            // demonstrate that the implemented methods don't fail anymore
            // UserInfo.AnotherStaticMethod("World");
            // UserInfo.StaticMethod(123, "321");

            Console.WriteLine("Using Mok Implementation");
            Console.WriteLine();

            // Set the custom implementation using custom UserInfoImplementation class
            // Suitable for complex use cases like implementing the whole API
            // Note that we don't have to implement all methods and properties,
            // we can provide the implementation for those we really need.
            // Calling the ApexMok NameSpace

            // Start Mocking
            MokSetup.InitMok();

            DemoApexClass.AnotherStaticMethod("Hello");
            DemoApexClass.StaticMethod(1, "b");
            DemoApexClass userInfoMok = new DemoApexClass("Mickey Mouse", 80);

            Console.WriteLine("NonStaticMethod returns {0}", userInfoMok.NonStaticMethod());
            Console.WriteLine("Name = {0}", userInfoMok.Name);
            Console.WriteLine("Age = {0}", userInfoMok.Age);

            try
            {
                DemoApexClass.StaticMethodMokAndReal("Jay");
                DemoApexClass.StaticMethodMokAndReal("jayonsoftware.com"); // this line falls back to the default implementation
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
