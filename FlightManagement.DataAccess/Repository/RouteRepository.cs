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
    public class RouteRepository : Repository<Route>, IRouteRepository
    {
        private readonly AppDbContext _db;
        public RouteRepository(AppDbContext db):base(db)
        {
                _db = db;
        }
        public void Update(Route route)
        {
            _db.Route.Update(route);
        }
    }
}
