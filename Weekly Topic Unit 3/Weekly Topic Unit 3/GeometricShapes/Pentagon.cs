using System;

//Ethan Smith

namespace GeometricShapes
{
    public class Pentagon : IGeometricShapes
    {
        public int NumberOfSides => 5;

        public double SideLength { get; set; }

        public double Area() => 5 * SideLength;

        public double Perimeter()
        {
            return (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * Math.Pow(SideLength, 2);
        }

        public int TotalMeasureOfAllAngles()
        {
            return 540;
        }
    }
}
