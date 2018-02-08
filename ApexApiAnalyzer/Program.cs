using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;

namespace ApexApiAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(opts => RunOptionsAndReturnExitCode(opts));
        }

        private static void RunOptionsAndReturnExitCode(CommandLineOptions opts)
        {
            var analyzer = new Analyzer();
            foreach (var item in opts.InputItems)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }

                if (item.Contains("://"))
                {
                    Console.Error.WriteLine("Processing URL: {0}", item);
                    analyzer.ProcessUrl(item);
                    continue;
                }

                if (item.EndsWith(".zip"))
                {
                    Console.Error.WriteLine("Processing ZIP archive: {0}", item);
                    analyzer.ProcessZipFiles(item);
                    continue;
                }

                if (item.EndsWith(".cls"))
                {
                    Console.Error.WriteLine("Processing Apex class: {0}", item);
                    analyzer.ProcessApexClasses(File.ReadAllText(item));
                    continue;
                }

                if (item.EndsWith(".cs"))
                {
                    Console.Error.WriteLine("Processing C# class: {0}", item);
                    analyzer.ProcessCSharpClasses(File.ReadAllText(item));
                    continue;
                }

                var dir = new DirectoryInfo(item);
                if (dir.Exists)
                {
                    Console.Error.WriteLine("Processing directory: {0}", item);
                    analyzer.ProcessDirectories(dir.FullName);
                    continue;
                }

                Console.Error.WriteLine("Skipping unsupported file or URL: {0}", item);
            }

            var classes = analyzer.Classes.Values;
            var report = opts.Markdown ?
                MarkdownReporter.GetReport(classes, opts.NotImplementedOnly) :
                SimpleReporter.GetReport(classes, opts.NotImplementedOnly);

            if (string.IsNullOrWhiteSpace(report) && classes.Any() && opts.NotImplementedOnly)
            {
                Console.Error.WriteLine("Warning: the report is empty because all used API classes are implemented.");
            }

            if (!string.IsNullOrWhiteSpace(opts.OutputFile))
            {
                Console.Error.WriteLine("Generating report: {0}", opts.OutputFile);
                File.WriteAllText(opts.OutputFile, report);
            }
            else
            {
                Console.WriteLine("{0}", report);
            }
        }
    }
}
