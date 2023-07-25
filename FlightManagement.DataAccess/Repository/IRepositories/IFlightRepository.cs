using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Repository.IRepositories
{
    public interface IFlightRepository : IRepository<Flight>
    {
        void Update(Flight flight);
    }
}
