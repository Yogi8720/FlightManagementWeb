using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.DataAccess.Repository.IRepositories
{
    public interface IRepository<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> predicate);

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? IncludeProperties = null);
        //IEnumerable<T> GetAll();

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
