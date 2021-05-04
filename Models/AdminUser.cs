using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class AdminUser : AUser
    {
        public string Username { get; set; }

        public AdminUser()
        {
            
        }

        public AdminUser(int id, string firstName, string lastName, string username, string password) : base(id, firstName, lastName, password)
        {
            Username = username;
        }
    }
}
