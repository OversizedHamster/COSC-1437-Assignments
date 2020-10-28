using System;
using AbstractClassLibrary;

namespace Demonstrator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ProfReynolds
             * notice how this implements exactly like the interface
             */
            AbstractGeometricShape myGeometricShapes;
            Console.WriteLine("Ethan Smith Demonstrator_3");
            Console.WriteLine();

            myGeometricShapes = new Triangle { SideLength = 123.456 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Square() { SideLength = 321.654 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();

            myGeometricShapes = new Pentagon() { SideLength = 1.123 };
            TellAboutTheShape(myGeometricShapes);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void TellAboutTheShape(AbstractGeometricShape thisShape)
        {
            Console.WriteLine($"This object is a {thisShape.GetType()}");
            Console.WriteLine(thisShape.Description());
            Console.WriteLine($"Number of Sides = {thisShape.NumberOfSides}");
            Console.WriteLine($"Length of the Sides = {thisShape.SideLength}");
            Console.WriteLine($"Area of the shape = {thisShape.Area()}");
        }
    }
}
