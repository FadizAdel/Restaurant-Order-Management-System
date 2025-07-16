using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order(int OrderId , DateOnly OrderOnly)
        {
            this.OrderId = OrderId;
            OrderDate = OrderOnly;
            OrderItems = new List<OrderItem>();
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}, Date: {OrderDate}");
            foreach (var item in OrderItems)
            {
                item.GetInfo();
            }
            Console.WriteLine($"Total: {GetOrderTotal():C}");
        }

        public decimal GetOrderTotal()
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
    }
}       
