using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using CitiesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesAPI.DataAccess
{
    public class RestarauntDBContext : DbContext
    {
        
        public RestarauntDBContext(DbContextOptions<RestarauntDBContext> options) : base()
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Restaraunt> Restaurants { get; set; }

        
    }
}
