using System;

//Ethan Smith

namespace AbstractClassLibrary
{
    public class Triangle : AbstractGeometricShape
    {
        public Triangle()
        {
            NumberOfSides = 3;
        }

        public override double Area() =>
            (Math.Sqrt(3) / 4) * Math.Pow(SideLength, 2);

        public override string Description()
        {
            return $"This Triangle is a {NumberOfSides} - sided geometric shape. Each side is {SideLength} and the area is {Area()}.";
        }
    }
}