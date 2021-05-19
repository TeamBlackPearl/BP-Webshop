using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BP_Webshop.Models
{
    public class User : AUser
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string Address { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Has to be 8 digits")]
        //[DataType(DataType.PhoneNumber, ErrorMessage = "Has to be 8 digits")]
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
