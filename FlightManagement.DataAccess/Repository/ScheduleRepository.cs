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
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        private readonly AppDbContext _db;
        public ScheduleRepository(AppDbContext db):base(db) 
        {
                _db = db;
        }
        public void Update(Schedule Schedule)
        {
            _db.Schedules.Update(Schedule);
        }
    }
}
