using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Square_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_4()
        {
            Square square = new Square();

            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            Square square = new Square();
            double expectedValue = 1.2d;

            square.SideLength = expectedValue;

            square.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            Square square = new Square();
            double sideLength = 5.6d;
            double expectedAreaMinAcceptable = 31.35d;
            double expectedAreaMaxAcceptable = 31.37d;

            square.SideLength = sideLength;

            square.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }

        [TestMethod]
        public void Verify_That_TotalMeasureOfAngles_Is_360()
        {
            Square square = new Square();

            square.TotalMeasureOfAllAngles().ShouldBe(360);
        }
    }
}
