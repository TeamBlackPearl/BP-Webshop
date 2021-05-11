using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public abstract class AUser
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public AUser()
        {
            
        }

        protected AUser(int id, string firstName, string lastName, string role, string email, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Email = email;
            Password = password;
        }
    }
}
