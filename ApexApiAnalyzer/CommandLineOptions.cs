using System.Collections.Generic;
using CommandLine;

namespace ApexApiAnalyzer
{
    public class CommandLineOptions
    {
        [Value(0, Required = true, HelpText = "Directories, ZIP files, Github project URLs to be processed")]
        public IEnumerable<string> InputItems { get; set; }

        [Option('m', "markdown", Default = false, Required = false, HelpText = "Generate reports in Markdown format")]
        public bool Markdown { get; set; }

        [Option('n', "noimpl", Required = false, HelpText = "Report only classes that have no implementation")]
        public bool NotImplementedOnly { get; set; }

        [Option('o', "output", Required = false, HelpText = "Save the report to the output file instead of printing to STDOUT")]
        public string OutputFile { get; set; }
    }
}
