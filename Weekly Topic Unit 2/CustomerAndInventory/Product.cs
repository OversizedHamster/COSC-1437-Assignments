using System;
using System.Collections.Generic;
using System.Text;

//Ethan Smith

namespace CustomerAndInventory
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public bool IsFragile { get; set; }
        public bool PayByWeight { get; set; }
    }
}
