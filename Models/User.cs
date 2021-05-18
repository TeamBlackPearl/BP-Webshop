using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class User : AUser
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Address { get; set; }
        [Required(ErrorMessage = "you need to enter your phone number"), Range(8,8, ErrorMessage = "Has to be 8 digits")]
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
