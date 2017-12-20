using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApexParser;

namespace ApexSharpApi
{
    public class CodeConverter
    {
        public static void ConvertToCSharp(DirectoryInfo apexLocation, DirectoryInfo cSharpLocation, string nameSpace)
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

        public static void ConvertToApex(DirectoryInfo cSharpLocation, DirectoryInfo apexLocation, int version)
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
