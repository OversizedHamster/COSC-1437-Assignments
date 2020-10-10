using System;
using System.Collections.Generic;
using System.Text;

//Ethan Smith

namespace CustomerAndInventory
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public double? ProduceWeight { get; set; }
        public bool DoubleBag { get; set; }
    }
}
