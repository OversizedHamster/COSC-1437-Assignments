//Ethan Smith

using System;

namespace AbstractClassLibrary
{
    public class Pentagon : AbstractGeometricShape
    {
        public Pentagon()
        {
            NumberOfSides = 5;
        }

        public override double Area() => (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(SideLength, 2);

        public override string Description()
        {
            return $"This Pentagon is a {NumberOfSides} - sided geometric shape. Each side is {SideLength} and the area is {Area()}.";
        }
    }
}