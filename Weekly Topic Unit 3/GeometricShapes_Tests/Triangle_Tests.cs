using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Triangle_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_3()
        {
            Triangle triangle = new Triangle();

            triangle.NumberOfSides.ShouldBe(3);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            Triangle triangle = new Triangle();
            double expectedValue = 1.2d;

            triangle.SideLength = expectedValue;

            triangle.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            Triangle triangle = new Triangle();
            double sideLength = 5.6d;
            double expectedAreaMinAcceptable = 13.579d;
            double expectedAreaMaxAcceptable = 13.581d;

            triangle.SideLength = sideLength;

            triangle.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }

        [TestMethod]
        public void Verify_That_TotalMeasureOfAngles_Is_180()
        {
            Triangle triangle = new Triangle();

            triangle.TotalMeasureOfAllAngles().ShouldBe(180);
        }
    }
}
