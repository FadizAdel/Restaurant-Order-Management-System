using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class MenuItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int id, string name, decimal price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Menu Item => ID: {ID}, Name: {Name}, Price: {Price:C}");
        }
    }
}
