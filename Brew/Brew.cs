using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Brewer
{
    public enum BrewStyle
    {
        FrenchPress,
        PodSystem
    }
    public class Brew : System.CommandLine.Command
    {
        public Brew(string name, string description = null) : base(name, description)
        {
            Add(new Option<BrewStyle>("--coffeeType"));
            Handler = CommandHandler.Create<BrewStyle>(BrewCoffee);
        }

        public void BrewCoffee(BrewStyle coffeeType)
        {
            Console.WriteLine(coffeeType.ToString());
            switch (coffeeType)
            {
                case BrewStyle.FrenchPress:
                    var press = new FrenchPress();
                    press.Brew();
                    press.Press();
                    press.Pour();
                    break;
                case BrewStyle.PodSystem:
                    var pod = new PodSystem();
                    pod.Brew();
                    pod.Pour();
                    break;
            }
        }

        private class FrenchPress
        {
            public FrenchPress()
            {
            }

            internal void Brew()
            {
                Console.WriteLine("Brewing.");
            }

            internal void Press()
            {
                Console.WriteLine("Pressing.");
            }

            internal void Pour()
            {
                Console.WriteLine("Pouring.");
            }
        }

        private class PodSystem
        {
            public PodSystem()
            {

            }

            internal void Brew()
            {
                Console.WriteLine("Brewing.");
            }

            internal void Pour()
            {
                Console.WriteLine("Pouring.");
            }
        }
    }
}