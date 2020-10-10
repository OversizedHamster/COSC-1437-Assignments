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

        [TestMethod]
        public void IsNullOrEmpty_HasContent()
        {
            string testCondition = "test";

            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBeFalse();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsEmpty()
        {
            string testCondition = string.Empty;

            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrEmpty_IsSpaces()
        {
            string testCondition = " ";

            var actualResult = testCondition.IsNullOrEmpty();

            actualResult.ShouldBeFalse();
        }

        #endregion

        #region IsNullOrWhiteSpace

        [TestMethod]
        public void IsNullOrWhiteSpace_HasContent()
        {
            string testCondition = "test";

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeFalse();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            string testCondition = string.Empty;

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpace_IsSpaces()
        {
            string testCondition = " ";

            var actualResult = testCondition.IsNullOrWhiteSpace();

            actualResult.ShouldBeTrue();
        }

        #endregion

        #region Left

        [TestMethod]
        public void Left_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.Left(5);

            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Left_NoCharacters()
        {
            string testCondition = string.Empty;

            var actualResult = testCondition.Left(5);

            actualResult.ShouldBeEmpty();
        }

        [TestMethod]
        public void Left_Normal()
        {
            string testCondition = "test";

            var actualResult = testCondition.Left(2);

            actualResult.ShouldBe("te");
        }

        [TestMethod]
        public void Left_TooManyCharacters()
        {
            string testCondition = "test";

            var actualResult = testCondition.Left(5);

            actualResult.ShouldBe("test");
        }

        #endregion

        #region Right

        [TestMethod]
        public void Right_IsNull()
        {
            string testCondition = null;

            var actualResult = testCondition.Right(5);

            actualResult.ShouldBeNull();
        }

        [TestMethod]
        public void Right_NoCharacters()
        {
            string testCondition = string.Empty;

            var actualResult = testCondition.Right(5);

            actualResult.ShouldBeEmpty();
        }

        [TestMethod]
        public void Right_Normal()
        {
            string testCondition = "test";

            var actualResult = testCondition.Right(1);

            actualResult.ShouldBe("est");
        }

        [TestMethod]
        public void Right_TooManyCharacters()
        {
            string testCondition = "test";

            var actualResult = testCondition.Right(5);

            actualResult.ShouldBeEmpty();
        }



        #endregion
    }
}
