using Microsoft.VisualStudio.TestTools.UnitTesting;

//Ethan Smith

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Customer_Tests
    {
        [TestMethod]
        public void Verify_The_ID_Is_Zero_When_Instantiated()
        {
            //assign
            var customer = new CustomerAndInventory.Customer();

            //action

            //assert
            Assert.AreEqual(0, customer.ID);
        }

        [TestMethod]
        public void Verify_The_ID_Can_Be_Assigned()
        {
            //assign
            var assignedID = 1234;
            var customer = new CustomerAndInventory.Customer();

            //action
            customer.ID = assignedID;

            //assert
            Assert.AreEqual(assignedID, customer.ID);
        }

        [TestMethod]
        public void Verify_The_First_Name_Can_Be_Assigned()
        {
            var firstName = "First";
            var customer = new CustomerAndInventory.Customer();

            customer.FirstName = firstName;

            Assert.AreEqual(firstName, customer.FirstName);
        }

        [TestMethod]
        public void Verify_The_Last_Name_Can_Be_Assigned()
        {
            var lastName = "Last";
            var customer = new CustomerAndInventory.Customer();

            customer.LastName = lastName;

            Assert.AreEqual(lastName, customer.LastName);
        }

        [TestMethod]
        public void Verify_The_Full_Name_Represents_The_First_And_Last_Names()
        {
            var firstName = "First";
            var lastName = "Last";
            var customer = new CustomerAndInventory.Customer();

            customer.FirstName = firstName;
            customer.LastName = lastName;

            Assert.AreEqual($"{firstName} {lastName}", customer.FullName());
        }

        [TestMethod]
        public void Verify_The_ValidateName_Returns_True_If_Both_Names_Have_2_Or_More_Characters_Each()
        {
            var firstName = "Fi";
            var lastName = "La";
            var customer = new CustomerAndInventory.Customer();

            customer.FirstName = firstName;
            customer.LastName = lastName;

            Assert.AreEqual(true, customer.ValidateName());
        }
    }
}
