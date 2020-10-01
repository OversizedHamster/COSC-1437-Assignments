using Microsoft.VisualStudio.TestTools.UnitTesting;

//Ethan Smith

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Product_Tests
    {
        [TestMethod]
        public void Verify_ID_Is_0_When_Instantiated()
        {
            var product = new CustomerAndInventory.Product();

            Assert.AreEqual(0, product.ID);
        }

        [TestMethod]
        public void Verify_ProductName_Can_Be_Assigned()
        {
            var product = new CustomerAndInventory.Product();
            var name = "eggs";

            product.ProductName = name;

            Assert.AreEqual(name, product.ProductName);
        }

        [TestMethod]
        public void Verify_ProductDescription_Can_Be_Assigned()
        {
            var product = new CustomerAndInventory.Product();
            var desc = "White";

            product.ProductDescription = desc;

            Assert.AreEqual(desc, product.ProductDescription);
        }
    }
}
