﻿using System;
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
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackPearl-DB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Bracelet> Bracelets { get; set; }
        public DbSet<Earring> Earrings { get; set; }
        public DbSet<HeadJewelry> HeadJewelries { get; set; }
        public DbSet<Necklace> Necklaces { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<Jewelry> Jewelries { get; set; }

    }
}
