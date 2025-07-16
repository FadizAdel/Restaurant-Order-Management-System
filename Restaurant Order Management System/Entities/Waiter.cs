using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class Waiter : Person
    {
        public decimal Salary { get; set; }
        public Waiter(int id, string name, string phone, decimal salary)
            : base(id, name, phone)
        {
            Salary = salary;
        }
        public override void GetRole()
        {
            Console.WriteLine($"{Name} is a Waiter with a salary of {Salary:C}.");
        }
    }
    
}
