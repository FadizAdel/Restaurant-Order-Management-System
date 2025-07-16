using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal class Chef : Person
    {
        public string Specialty { get; set; }
        public Chef(int id, string name, string phone, string specialty)
            : base(id, name, phone)
        {
            Specialty = specialty;
        }
        public override void GetRole()
        {
            Console.WriteLine($"{Name} is a Chef specialized in {Specialty}.");
        }
    }
}
