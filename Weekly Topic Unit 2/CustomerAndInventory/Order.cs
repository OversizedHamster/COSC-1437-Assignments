using System;

//Ethan Smith

namespace CustomerAndInventory
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public bool HasCoupon { get; set; }
        public bool HasMembershipDiscount { get; set; }
    }
}
