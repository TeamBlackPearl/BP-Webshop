using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class AdminService
    {

        //statusveryfied

        public List<AdminUser> AdminUserList { get; set; }
        private GenericCRUDMethods<AdminUser> GenericCrudMethods { get; set; }

        public AdminService(GenericCRUDMethods<AdminUser> genericCrudMethods)
        {
            GenericCrudMethods = genericCrudMethods;

            AdminUserList = genericCrudMethods.GetObjectsAsync().Result.ToList();
        }

        public async Task AddAdminUserAsync(AdminUser adminUser)
        {
            AdminUserList.Add(adminUser);
            await GenericCrudMethods.AddObjectAsync(adminUser);
        }

        public IEnumerable<AdminUser> GetAdminUsers()
        {
            return AdminUserList;
        }

    }

}
    