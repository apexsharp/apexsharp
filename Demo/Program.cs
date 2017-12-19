﻿using Apex;

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
        public static DirectoryInfo cSharpLocation = new DirectoryInfo(@"/ApexSharp/Demo/CSharpClasses/");

        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            // Start Logging
            Setup.StartLogging();

            // Always Initialize your settings when ever you are connecting to SF
            Setup.Init();

            // Keep Track of the API Limits
            Console.WriteLine($"Api Request Remaining {Limits.GetApiLimits().DailyApiRequests.Remaining}");

            // Create Offline classes for SObjects
            // CreateOffLineClasses();

            ConvertToCSharp();

            // foreach (var contact in CSharpClasses.Demo.getContacts()) Console.WriteLine(contact.Email);
           

            //ConvertToApex();

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
