using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Services;

namespace BP_Webshop.Models
{
    public class AdminUser : AUser
    {

        public AdminUser()
        {
            
        }

        public AdminUser(int id, string firstName, string lastName, string role, string email, string password) : base(id, firstName, lastName, role, email, password)
        {

        }


    }
}
