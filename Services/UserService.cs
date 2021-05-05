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

        //task og async
        public async Task AddUser(User users)
        {
            UsersList.Add(users);
            //Jsonfileservice
            //await DBService.AddObjectAsync(user);
        }
        
        ////den tjekker om email allerede er i brug. retuner true hvis den er.
        //// <param name="email">Email af den user der forsøger at registere sig.</param>
        //public bool IsEmailInUse(string email)
        //{
        //    // tjekker om alle users i userslist, om nye email matcher en af de allerede eksisterende.
        //    return UsersList.Any(u => u.Email == email); 
        //}
        ////Validere om user taster correct password og sit username.
        ////Returner User object hvis det eksistere.
        ////bool - true false
        ////Lampda syntax
        //public bool ValidateLogin( string email, string password)
        //{
        //    if (IsEmailInUse(email))
        //    {
        //        //tjekker om pass matcher pass
        //        if (UsersList.Any(u=>u.Password == password)) 
        //        {
        //            return true;
        //        }
        //    }
        //    //else retuner false
        //    return false;
        //}
    }
}
