using FlightManagement.DataAccess.Data;
using FlightManagement.DataAccess.Repository.IRepositories;
using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Repository
{
    public class FlightRepository : Repository<Flight>, IFlightRepository
    {
        private AppDbContext _db;
        public FlightRepository(AppDbContext db): base(db)
        {
            _db = db; 
        }
        public void Update(Flight flight)
        {
            _db.Flights.Update(flight);
        }
    }
}
