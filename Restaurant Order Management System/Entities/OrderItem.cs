using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class OrderItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; } 

        public OrderItem(MenuItem item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return Item.Price * Quantity;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Quantity} x {Item.Name} => {GetTotalPrice():C}");
        }
    }
}
