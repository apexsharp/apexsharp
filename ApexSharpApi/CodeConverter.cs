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
            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert APEX to C#
            ApexSharpParser.ConvertToCSharp(apexLocation.FullName, cSharpLocation.FullName, nameSpace);
        }

        public static void ConvertToApex(DirectoryInfo cSharpLocation, DirectoryInfo apexLocation, int version)
        {

            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert C# to Apex
            ApexSharpParser.ConvertToApex(cSharpLocation.FullName, apexLocation.FullName, version);
        }

        public static void ConvertToCSharp(FileInfo apexFile, DirectoryInfo cSharpLocation, string nameSpace)
        {
            if (!apexFile.Exists)
            {
                throw new DirectoryNotFoundException(apexFile.FullName);
            }

            if (!cSharpLocation.Exists)
            {
                throw new DirectoryNotFoundException(cSharpLocation.FullName);
            }

            // Convert APEX to C#
            //ApexSharpParser.ConvertToCSharp(apexLocation.FullName, cSharpLocation.FullName, nameSpace);
        }

        public static void ConvertToApex(FileInfo cSharpFile, DirectoryInfo apexLocation, int version)
        {

            if (!apexLocation.Exists)
            {
                throw new DirectoryNotFoundException(apexLocation.FullName);
            }

            if (!cSharpFile.Exists)
            {
                throw new FileNotFoundException(cSharpFile.FullName);
            }

            // Convert C# to Apex
            // ApexSharpParser.ConvertToApex(cSharpLocation.FullName, apexLocation.FullName, version);
        }
    }
}
