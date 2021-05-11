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

        private AdminService _adminService;


        public UserService(GenericCRUDMethods<User> dbService, AdminService adminService)
        {
            //ini ref
            _adminService = adminService;
            DbService = dbService;
            UsersList = DbService.GetObjectsAsync().Result.ToList();
        }


        //task og async
        public async Task AddUser(User users)
        {
            UsersList.Add(users);
            await DbService.AddObjectAsync(users);
        }

        public IEnumerable<User> GetUsers()
        {
            return UsersList;
        }

        public List<AUser> GetAllUserTypes()
        {
            //local list
            List<AUser> allUserTypes = new List<AUser>
                //henter alle admin users, og tæller antal af admin users
                //og henter alle users, og tæller antal af users
                (_adminService.GetAdminUsers().Count() + GetUsers().Count());
            //tager det antal admin users der er fundet og ligger det ind i 
            //den nye liste allusertypes
            allUserTypes.AddRange(_adminService.GetAdminUsers());
            //sker det samme her, og henter getusers direkte
            allUserTypes.AddRange(GetUsers());
            return allUserTypes;
        }

    }
}
