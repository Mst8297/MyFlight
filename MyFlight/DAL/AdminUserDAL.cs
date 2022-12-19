using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyFlight.Models;
namespace MyFlight.DAL
{
    public class AdminUserDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AdminUser>().ToTable("AdminUsertbl");
        }
        public DbSet<AdminUser> adminUsers { get; set; }
    }
}