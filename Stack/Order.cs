using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            System.Console.WriteLine($"Order {OrderId} processed");
        }
    }
}