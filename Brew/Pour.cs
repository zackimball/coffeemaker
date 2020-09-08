using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Brew
{
    public class Pour : Command
    {
        public Pour(string name, string description = null) : base(name, description)
        {
            Handler = CommandHandler.Create(PourCoffee);
        }

        private void PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            Console.WriteLine("Coffee is ready to drink.");
        }
    }
}