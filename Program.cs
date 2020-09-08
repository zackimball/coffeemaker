using System;
using CoffeeMaker;

namespace coffeemaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making the coffee.");
            var maker = new CoffeeMake();
            maker.MakeCoffee(Brew.CoffeeType.Espresso);
        }
    }
}
