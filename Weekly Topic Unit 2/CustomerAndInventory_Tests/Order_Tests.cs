using Microsoft.VisualStudio.TestTools.UnitTesting;

//Ethan Smith

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Order_Tests
    {
        [TestMethod]
        public void Verify_Order_ID_Is_0_When_Instantiated()
        {
            var order = new CustomerAndInventory.Order();

            Assert.AreEqual(0, order.ID);
        }

        [TestMethod]
        public void Verify_CustomerID_Can_Be_Assigned()
        {
            var order = new CustomerAndInventory.Order();
            var customerID = 1337;

            order.CustomerID = customerID;

            Assert.AreEqual(customerID, order.CustomerID);
        }
    }
}
