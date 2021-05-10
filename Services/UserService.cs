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
        public GenericCRUDMethods<User> DbService { get; set; }


        public UserService(GenericCRUDMethods<User> dbService)
        {
            DbService = dbService;
            UsersList = DbService.GetObjectsAsync().Result.ToList();
        }


        //task og async
        public async Task AddUser(User users)
        {
            UsersList.Add(users);
            await DbService.AddObjectAsync(users);
        }

    }
}
