using System;

namespace HelloWorld.Homework1
{
    public class Bicycle
    {
        public int Gears = 15;
        public string Color = "Black";
        private string _formula = "a*b";

        //Its public – so accessible outside class
        public int GetGears()
        {
            return Gears;
        }

        //Its public – so accessible outside class
        public string GetColor()
        {
            return Color;
        }

        //Its private – so not accessible outside class
        private string GetGearRatioFormula()
        {
            return _formula;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bicycle objBicycle = new Bicycle();
            Console.WriteLine("Bicycle gears is : " + objBicycle.GetGears()); //accessible outside "Bicycle"
            Console.WriteLine("Bicycle color is : " + objBicycle.GetColor()); //accessible outside "Bicycle"
            Console.Read();
        }
    }
}

