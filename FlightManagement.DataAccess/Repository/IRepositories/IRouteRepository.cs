using FlightManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Repository.IRepositories
{
    public interface IRouteRepository : IRepository<Route>
    {
        void Update(Route route);
    }
}
