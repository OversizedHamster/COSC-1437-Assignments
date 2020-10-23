//Ethan Smith

namespace AbstractClassLibrary
{
    public abstract class AbstractGeometricShape
    {
        public int NumberOfSides { get; internal set; }
        public double SideLength { get; set; }
        public double Perimeter => NumberOfSides * SideLength;
        public abstract double Area();
        public int TotalMeasureOfAllAngles() => (NumberOfSides - 2) * 180;
        public abstract string Description();
    }
}
