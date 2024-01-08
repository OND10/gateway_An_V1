using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Domain.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        //Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T model);

        Task<T> UpdateAsync(T model);

        Task<T> DeleteAsync(T model);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> Query(string query);

    }
}
