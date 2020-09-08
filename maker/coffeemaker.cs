using System;
using Brew;

namespace CoffeeMaker
{
    public class CoffeeMake
    {
        public ICoffee MakeCoffee(CoffeeType typeOfCoffee)
        {
            var cup = GetNewCoffee(typeOfCoffee);
            cup.Grind();
            cup.Brew();
            cup.Pour();

            return cup;
        }

        private ICoffee GetNewCoffee(CoffeeType typeOfCoffee)
        {
            switch (typeOfCoffee)
            {
                case CoffeeType.Espresso: return new Espresso();
                case CoffeeType.FrenchPress: return new FrenchPress();
                default: return new FrenchPress();
            }
        }
    }
}