using GeometricShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace GeometricShapes_Tests
{
    [TestClass]
    public class Pentagon_Tests
    {
        [TestMethod]
        public void Verify_That_NumberOfSides_Is_5()
        {
            Pentagon pentagon = new Pentagon();

            pentagon.NumberOfSides.ShouldBe(5);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            Pentagon pentagon = new Pentagon();
            double expectedValue = 1.2d;

            pentagon.SideLength = expectedValue;

            pentagon.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            Pentagon pentagon = new Pentagon();
            double sideLength = 5.6d;
            double expectedAreaMinAcceptable = 27d;
            double expectedAreaMaxAcceptable = 29d;

            pentagon.SideLength = sideLength;

            pentagon.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }

        [TestMethod]
        public void Verify_That_TotalMeasureOfAngles_Is_540()
        {
            Pentagon pentagon = new Pentagon();

            pentagon.TotalMeasureOfAllAngles().ShouldBe(540);
        }
    }
}
