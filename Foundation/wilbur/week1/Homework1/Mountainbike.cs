using System;


namespace HelloWorld.Homework1
{
    public class Mountainbike : Bicycle
    {
        public virtual void RearPegs()
        {
            Console.WriteLine("Mountain Bike has Rear Pegs.");
        }

        public virtual void FrontPegs()
        {
            Console.WriteLine("Mountain Bike has Front Pegs.");
        }

        public virtual int Reflectors { get; } = 5;
        public virtual int Brakes { get; } = 3;


    }
}
