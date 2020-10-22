using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class StringExtensionTests
    {
        #region IsNullOrEmpty

        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", false)]
        [DataRow(null, true)]
        [DataRow("Prof Reynolds", false)]
        public void IsNullOrEmpty_Test(string testCondition, bool expectedResult)
        {
            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBe(expectedResult);
        }

        #endregion

        #region IsNullOrWhiteSpace

        [DataTestMethod]
        [DataRow("", true)]
        [DataRow(" ", true)]
        [DataRow(null, true)]
        [DataRow("Prof Reynolds", false)]
        public void IsNullOrWhiteSpace_Test(string testCondition, bool expectedResult)
        {
            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBe(expectedResult);
        }

        #endregion

        #region Left

        [DataTestMethod]
        [DataRow("Prof Reynolds", 8, "Prof Rey")]
        [DataRow("Prof Reynolds", 99, "Prof Reynolds")]
        [DataRow("Prof Reynolds", 0, "")]
        [DataRow(null, 99, null)]
        public void Left_Test(string testCondition, int numCharacters, string expectedResult)
        {
            var actualResult = testCondition.Left(numCharacters);

            actualResult.ShouldBe(expectedResult);
        }

        #endregion

        #region Right

        [DataTestMethod]
        [DataRow("Prof Reynolds", 1, "rof Reynolds")]
        [DataRow("Prof Reynolds", 99, "")]
        [DataRow("Prof Reynolds", 0, "Prof Reynold")]
        [DataRow(null, 99, null)]
        public void Right_Test(string testCondition, int numCharacters, string expectedResult)
        {
            var actualResult = testCondition.Right(numCharacters);

            actualResult.ShouldBe(expectedResult);
        }

        #endregion
    }
}
