using System;

namespace HelloWorld.Homework1
{
    public class Bicycle1
    {
        //properties
        private int gears;
        private string color;
        public Bicycle1()
        {
            //constructor without parameter
        }

        private Bicycle1(int ger, string col)
        {
            //constructor with two parameters "ger" and "col"
            gears = ger;
            color = col;
        }

        public void DisplayBicycle1Data()
        {
            Console.WriteLine("Bicycles gears are " + gears + " and color is " + color);
        }
    }
}
 public class Program
 {
     public static void Main(string[] args)
     {
         Bicycle1 objBicycle = new Bicycle1();
         Console.WriteLine("Bicycle1 gears are : " + objBicycle.GetGears()); //accessible outside "Bicycle"
         Console.WriteLine("Bicycle1 color is : " + objBicycle.GetColor()); //accessible outside "Bicycle"
         Console.Read();
     }
 }
