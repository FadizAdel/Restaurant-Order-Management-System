using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class Customer : Person
    {
        public string Address { get; set; }

        public Customer(int id, string name, string phone, string address)
            : base(id, name, phone)
        {
            Address = address;
        }

        public override void GetRole()
        {
            Console.WriteLine($"{Name} is a Customer.");
        }
    }
}
