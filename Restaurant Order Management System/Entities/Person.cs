using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System.Entities
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Person(int id , string name , string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public abstract void GetRole();

    }
}
