using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BP_Webshop.Models
{
    public class BlackPDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BlackPearl-DB-V3; Integrated Security=True; Connect Timeout=30; Encrypt=False");

            //options.UseSqlServer(@"Data Source=ebrusqlserver.database.windows.net;Initial Catalog=BlackPearl-DBV2;User ID=ebru0152;Password=ZeaKMGFC!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Bracelet> Bracelets { get; set; }
        public DbSet<Earring> Earrings { get; set; }
        public DbSet<HeadJewelry> HeadJewelries { get; set; }
        public DbSet<Necklace> Necklaces { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Jewelry> Jewelries { get; set; }

    }
}
