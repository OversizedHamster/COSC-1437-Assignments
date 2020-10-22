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
            var square = new Square();

            square.NumberOfSides.ShouldBe(4);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            var square = new Square();
            var expectedValue = 1.2d;

            square.SideLength = expectedValue;

            square.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            var square = new Square();
            var sideLength = 5.6d;
            var expectedAreaMinAcceptable = 31.35d;
            var expectedAreaMaxAcceptable = 31.37d;

            square.SideLength = sideLength;

            square.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }

        [TestMethod]
        public void Verify_That_TotalMeasureOfAngles_Is_360()
        {
            var square = new Square();

            square.TotalMeasureOfAllAngles().ShouldBe(360);
        }

        [TestMethod]
        public void Verify_The_Description_Returns_Value()
        {
            var square = new Square();

            square.Description().ShouldNotBeNullOrWhiteSpace();
        }
    }
}
