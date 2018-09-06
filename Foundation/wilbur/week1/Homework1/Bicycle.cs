using System;

namespace HelloWorld.Homework1
{
    public class Bicycle
    {
        public virtual int gears { get; set; } = 25;

        public string Wheels { set; get; }

        public string HandleBars { set; get; }

        public void Brake(string type)
        {
            Console.WriteLine(type);
        }

        public virtual void Pedal()
        {
            Console.WriteLine("Push the Pedal to go.");
        }
    }
}