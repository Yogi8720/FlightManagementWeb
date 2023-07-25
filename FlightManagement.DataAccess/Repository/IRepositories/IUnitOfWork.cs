using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Repository.IRepositories
{
    public interface IUnitOfWork
    {
        public IFlightRepository Flight { get; }
        void Save();
    }
}
