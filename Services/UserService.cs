using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class UserService
    {
        //Liste med users
        public List<User> UsersList { get; set; }

        public UserService()
        {
            
        }

        public void AddUser(User user)
        {
            UsersList.Add(user);
            //Jsonfileservice
            //DBService.AddObjectAsync
        }
    }
}
