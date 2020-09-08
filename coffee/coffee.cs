using System;

namespace Brew
{
    public enum Granularity
    {
        SuperFine = 1,
        Fine = 2,
        Regular = 3,
        Course = 4,
        Chunky = 5,
        WholeBean = 6
    }

    public enum CoffeeType
    {
        Espresso = 1,
        FrenchPress = 2
    }

    public interface ICoffee
    {
        float Temperature { get; set; }
        bool Brewed { get; set; }
        public bool Ground { get; set; }
        public bool Poured { get; set; }
        public int AmountOfCoffeeFlOz { get; set; }
        public void Grind();
        public void Brew();
        public void Pour();
        public void GrindFiner();
    }

    public class FrenchPress : ICoffee
    {
        public float Temperature { get; set; }
        public bool Brewed { get; set; } = false;
        public bool Ground { get; set; } = false;
        public bool Poured { get; set; } = false;
        public int AmountOfCoffeeFlOz { get; set; } = 8;
        public Granularity GrindType { get; set; } = Granularity.WholeBean;
        public FrenchPress() { }

        public void Grind()
        {
            Console.WriteLine("Grinding coffee");
            Console.WriteLine("Coffee grinder goes whirrr");
            GrindFiner()
            Ground = true;
            Console.WriteLine("Coffee is ground.");
        }
        public void GrindFiner()
        {

        }
        public void Brew()
        {
            Console.WriteLine("Brewing coffee");
            Brewed = true;
            Console.WriteLine("Coffee brewed.");
        }

        public void Pour()
        {
            Console.WriteLine("Coffee pouring.");
            Poured = true;
            Console.WriteLine("Coffee is poured");
        }
    }

    public class Espresso : ICoffee
    {
        public float Temperature { get; set; }
        public bool Brewed { get; set; }
        public bool Ground { get; set; }
        public bool Poured { get; set; }
        public int AmountOfCoffeeFlOz { get; set; }

        public Granularity GrindType { get; set; } = Granularity.WholeBean;

        public Espresso() { }

        public void Grind()
        {
            GrindFiner();
        }

        public void GrindFiner()
        {
            while (GrindType != Granularity.SuperFine)
                GrindType = GrindType - 1;
        }

        public void Brew()
        {

        }

        public void Pour()
        {

        }
    }
}