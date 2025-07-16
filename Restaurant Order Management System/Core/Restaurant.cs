using Restaurant_Order_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Core
{
    internal class Restaurant
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<Order> Orders { get; set; }
        public List<Person> Persons { get; set; }
        public static int TotalOrders { get; set; }

        public Restaurant()
        {
            MenuItems = new List<MenuItem>();
            Orders = new List<Order>();
            Persons = new List<Person>();
        }

        public void AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
        }
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
            TotalOrders++;
        }
        public void AddPerson(Person person)
        {
            Persons.Add(person);
        }
        public void ShowMenu()
        {
            if (MenuItems.Count == 0)
            {
                Console.WriteLine("Menu is empty.");
                return;
            }

            Console.WriteLine("Restaurant Menu:");
            foreach (var item in MenuItems)
            {
                item.GetInfo();
            }
        }
        public void ShowOrders()
        {
            if (Orders == null || Orders.Count == 0)
            {
                Console.WriteLine("No orders placed yet.");
                return;
            }
            Console.WriteLine($"Total Orders: {TotalOrders}");
            foreach (var order in Orders)
            {
                order.ShowOrderDetails();
                Console.WriteLine("-------------------------------------------------------");
            }
        }

    }
}

