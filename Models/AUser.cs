using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BP_Webshop.Models
{
    public abstract class AUser
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        //[MinLength(3, ErrorMessage = "Min. 3 letters is needed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        //[MinLength(3, ErrorMessage = "Min. 3 letters is needed")]
        public string LastName { get; set; }
        public string Role { get; set; }

        [Required(ErrorMessage = "Email is required")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "@ is needed")]
        //[EmailAddress(ErrorMessage = "@ is needed")]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "@ is needed")]
        public string Email { get; set; }

        [Required]
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
