using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Cart Cart { get; private set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            Cart = new Cart(); 
        }
    }
}
