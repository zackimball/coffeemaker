using System;
using System.CommandLine;
using Brewer;

namespace coffeemaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootCommand = new RootCommand() { new Brewer.Brew("brew") };
            rootCommand.InvokeAsync(args).Wait();
        }
    }
}
