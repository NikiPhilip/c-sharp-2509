
//: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered. 
//Define an Order class with an OrderStatus property to manage the status of each order.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered
        }
    public class Order
    {
        private static List<Order> orders = new List<Order>();

        public int Orderid {  get; set; }
        public string Customername {  get; set; }
        public OrderStatus status { get; set; }

        public Order(int orderid, string customername)
        {
            Orderid = orderid;
            Customername = customername;
            status = OrderStatus.Pending;
        }
        public static Order AddOrder(int orderId, string customerName)
        {
            Order newOrder = new Order(orderId, customerName);
            orders.Add(newOrder); // Add the order to the list
            Console.WriteLine($"Order added: {newOrder.Orderid} - {newOrder.Customername}, Status: {newOrder.status}");
            return newOrder;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Orderid:{Orderid}");
            Console.WriteLine($"Customername:{Customername}");
            Console.WriteLine($"OrderStatus:{status}");

        }
        public static void DisplayAllOrders()
        {
            Console.WriteLine("\nAll Orders:");
            foreach (Order order in orders)
            {
                order.DisplayInfo();
                Console.WriteLine(); 
            }
        }





    }
}
