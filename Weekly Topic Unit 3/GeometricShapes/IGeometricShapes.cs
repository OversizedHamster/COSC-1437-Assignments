//Ethan Smith

namespace GeometricShapes
{
    public interface IGeometricShapes
    {
        int NumberOfSides { get; }
        double SideLength { get; set; }
        double Perimeter();
        double Area();
        int TotalMeasureOfAllAngles();
    }
}
