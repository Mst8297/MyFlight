using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFlight.Models;
using System.Data.Entity;



namespace MyFlight.DAL
{
    public class FlightsDAL :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Flights>().ToTable("Flightstbl");
        }
        public DbSet<Flights> flight { get; set; }
    }
}