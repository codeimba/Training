using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class TheMain
    {
        public static void Main(string[] args)
        {
            Queue<Order> myOrdersQueue = new Queue<Order>();

            foreach (Order item in RecieveOrdersFromBranch1())
            {
                myOrdersQueue.Enqueue(item);
            }

            foreach (Order item in RecieveOrdersFromBranch2())
            {
                myOrdersQueue.Enqueue(item);
            }

            while (myOrdersQueue.Count > 0)
            {
                Order currentOrder = myOrdersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
            
        }

        static Order[] RecieveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }

    }
}