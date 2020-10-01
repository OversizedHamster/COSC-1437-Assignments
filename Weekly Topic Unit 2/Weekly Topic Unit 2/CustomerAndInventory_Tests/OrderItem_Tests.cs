using Microsoft.VisualStudio.TestTools.UnitTesting;

//Ethan Smith

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class OrderItem_Tests
    {
        [TestMethod]
        public void Verify_ID_Is_0_When_Instantiated()
        {
            var orderItem = new CustomerAndInventory.OrderItem();

            Assert.AreEqual(0, orderItem.ID);
        }

        [TestMethod]
        public void Verify_OrderID_Can_Be_Assigned()
        {
            var orderItem = new CustomerAndInventory.OrderItem();
            var orderID = 42;

            orderItem.OrderID = orderID;

            Assert.AreEqual(orderID, orderItem.OrderID);
        }

        [TestMethod]
        public void Verify_ProductID_Can_Be_Assigned()
        {
            var orderItem = new CustomerAndInventory.OrderItem();
            var productID = 73;

            orderItem.ProductID = productID;

            Assert.AreEqual(productID, orderItem.ProductID);
        }
    }
}
