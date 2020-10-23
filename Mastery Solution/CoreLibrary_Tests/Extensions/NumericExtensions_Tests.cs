using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class NumericExtensions_Tests
    {
        [DataTestMethod]
        [DataRow("12", 999, 12)]
        [DataRow("12.12", 999, 12)]
        [DataRow("0", 999, 0)]
        [DataRow("-1", 999, -1)]
        [DataRow(null, 999, 999)]
        [DataRow("test", 999, 999)]
        [DataRow("123.45.67", 999, 999)]
        public void ToIntTest(object testValue, int defaultValue, int expectedResult)
        {
            int intResult = testValue.ToInt(defaultValue);

            intResult.ShouldBe(expectedResult);
        }
    }
}
