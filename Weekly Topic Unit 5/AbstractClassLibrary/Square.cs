//Ethan Smith

namespace AbstractClassLibrary
{
    public class Square : AbstractGeometricShape
    {
        public Square()
        {
            NumberOfSides = 4;
        }

        public override double Area() => SideLength * SideLength;

        public override string Description()
        {
            return $"This Square is a {NumberOfSides} - sided geometric shape. Each side is {SideLength} and the area is {Area()}.";
        }
    }
}