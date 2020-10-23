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
            var triangle = new Triangle();

            triangle.NumberOfSides.ShouldBe(3);
        }

        [TestMethod]
        public void Verify_The_SideLength_May_Be_Set_And_Retrieved()
        {
            var triangle = new Triangle();
            var expectedValue = 1.2d;

            triangle.SideLength = expectedValue;

            triangle.SideLength.ShouldBe(expectedValue);
        }

        [TestMethod]
        public void Verify_The_Area_Is_Calculated_Accurately()
        {
            var triangle = new Triangle();
            var sideLength = 5.6d;
            var expectedAreaMinAcceptable = 13.579d;
            var expectedAreaMaxAcceptable = 13.581d;

            triangle.SideLength = sideLength;

            triangle.Area().ShouldBeInRange(expectedAreaMinAcceptable, expectedAreaMaxAcceptable);
        }

        [TestMethod]
        public void Verify_That_TotalMeasureOfAngles_Is_180()
        {
            var triangle = new Triangle();

            triangle.TotalMeasureOfAllAngles().ShouldBe(180);
        }

        [TestMethod]
        public void Verify_The_Description_Returns_Value()
        {
            var triangle = new Triangle();

            triangle.Description().ShouldNotBeNullOrWhiteSpace();
        }
    }
}
