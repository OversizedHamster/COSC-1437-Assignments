using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace CoreLibrary_Tests.Extensions
{
    [TestClass]
    public class BooleanExtensions_Tests
    {
        [DataTestMethod]
        [DataRow("true", false, true)]
        [DataRow("false", false, false)]
        [DataRow("-1", false, false)]
        [DataRow("-1", true, true)]
        [DataRow(1, false, false)]
        [DataRow(1, true, true)]
        [DataRow(0, false, false)]
        [DataRow(0, true, true)]
        [DataRow(null, false, false)]
        [DataRow(null, true, true)]
        [DataRow("test", false, false)]
        [DataRow("test", true, true)]
        [DataRow("123.45.67", false, false)]
        [DataRow("123.45.67", true, true)]
        [DataRow(true, false, true)]
        [DataRow(false, true, false)]
        public void ToBoolTest(object testValue, bool defaultValue, bool expectedResult)
        {
            bool boolResult = testValue.ToBool(defaultValue);

            boolResult.ShouldBe(expectedResult);
        }
    }
}
