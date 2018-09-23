using System;

namespace HelloWorld.Homework1
{
    /*
        This class inherits from its parent class MountainBike, and also
        gains all of the Mountain Bike's inherited attributes from
        the Bicycle Class.
     */
    public class DownHillBike : Mountainbike
    {
        // Class variable
        // Override auto property and give it a new default value
        // As of C# 6, this is the preferred way
        public override int Reflectors { get; } = 7;

        // Class variable
        // Override auto property and give it a new default value
        // As of C# 6, this is the preferred way
        public override int Brakes { get; } = 2;


    }
}

