using System;


namespace HelloWorld.Homework1
{
    public class MountainBike : Bicycle
    {
        private int _sprocket = 42;

        public virtual void MyMountainBikeColor()
        {
            Console.WriteLine("Mountain Bike color is Blue.");
        }

    }
}