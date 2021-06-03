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
        public async Task AddUserAsync(User user)
        {
            UsersList.Add(user);
            await DbService.AddObjectAsync(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return UsersList;
        }
        //1.en local list oprettes
        //2.henter alle adminUsers, og tæller antallet af adminUsers
        //3.henter alle users, og tæller antallet af users
        //4.tager det antal af adminUsers der er fundet og ligger det ind i 
        //den nye liste allUserTypes, der sker det samme med Users
        //5.til sidst returnere den listen allUserTypes
        public List<AUser> GetAllUserTypes()
        {
           
            List<AUser> allUserTypes = new List<AUser>
            //henter, tæller    
            (_adminService.GetAdminUsers().Count() + GetUsers().Count());
            //ligger adminUsers ind i listen
            allUserTypes.AddRange(_adminService.GetAdminUsers());
            //ligger Users ind i listen
            allUserTypes.AddRange(GetUsers());
            //returnere listen
            return allUserTypes;
        }

        public User GetUserByFirstName(string firstName)
        {
            return UsersList.Find(user => user.FirstName == firstName);
        }
    }
}
