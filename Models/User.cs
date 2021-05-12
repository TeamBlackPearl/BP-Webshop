using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class User : AUser
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public User()
        {
            
        }

        public User(int id, string firstName, string lastName, string address, string phoneNumber, string role, string email, string password) : base(id, firstName, lastName, role, email, password)
        {
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
