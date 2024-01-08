using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Common.Enums;
using UserManagement_Domain.Common.Exceptions;
using UserManagement_Domain.Entities;
using UserManagement_Domain.IRepositories;

namespace UserManagement_Infustracture.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

       

        public Task<T> AddAsync(T model)
        {
            throw new ModelNullException(nameof(model),"Repo Add Exception");
        }

        public Task<T> DeleteAsync(T model)
        {
            throw new ModelNullException(nameof(model), "Repo Delete Exception");
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new ModelNullException(nameof(Exception), "Repo Add Exception");
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new IdNullException("Repo GetId Exception");
        }

        public Task<IEnumerable<T>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public Task<T> UpdateAsync(T model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }
    }
}
