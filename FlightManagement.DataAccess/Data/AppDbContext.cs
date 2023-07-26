using FlightManagement.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
