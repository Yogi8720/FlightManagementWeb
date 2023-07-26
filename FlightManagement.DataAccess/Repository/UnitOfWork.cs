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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Flight = new FlightRepository(_db);
            Route = new RouteRepository(_db);
            Schedule = new ScheduleRepository(_db);
        }

        public IFlightRepository Flight { get; private set; }

        public IRouteRepository Route { get; private set; }

        public IScheduleRepository Schedule { get; private set; }

        public void Save()
        {
           _db.SaveChanges();
        }
    }
}
