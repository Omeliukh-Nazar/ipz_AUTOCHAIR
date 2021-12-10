using ipz_Server_AUTOCHAIR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ipz_Server_AUTOCHAIR
{
    public class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ShopContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=shopdb;Trusted_Connection=True;");
        }
    }
}
