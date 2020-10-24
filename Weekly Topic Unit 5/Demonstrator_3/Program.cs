using System;
using GeometricShapes;

//Ethan Smith

namespace Demonstrator_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IGeometricShapes myGeometricShapes;
            Console.WriteLine("Ethan Smith Demonstrator_3");
            Console.WriteLine();

            /*
             * ProfReynolds
             * this is exactly what I was looking for
             */
            myGeometricShapes = new Triangle {SideLength = 123.456};
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Square() { SideLength = 321.654 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Pentagon() {SideLength = 1.123};
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void TellAboutTheShape(IGeometricShapes thisShape)
        {
            Console.WriteLine($"This object is a {thisShape.GetType()}");
            Console.WriteLine(thisShape.Description());
            Console.WriteLine($"Number of Sides = {thisShape.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {thisShape.SideLength}");
            Console.WriteLine($"Perimeter of the shape = {thisShape.Perimeter()}");
            Console.WriteLine($"Area of the shape = {thisShape.Area()}");
        }
    }
}
