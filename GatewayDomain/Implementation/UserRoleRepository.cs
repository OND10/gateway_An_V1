using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Common.Exceptions;
using UserManagement_Domain.Entities;
using UserManagement_Domain.Interfaces;

namespace UserManagement_Infustracture.Implementation
{
    public class UserRoleRepository: GenericRepository<UserRole>, IUserRoleRepository
    {
        public List<UserRole> userroles;
    

        public UserRoleRepository()
        {
            userroles = new List<UserRole>()
            {
                new UserRole
                {
                   Id = 1,
                   UserId = 1,
                   RoleId = 1,
                },
                new UserRole
                {
                   Id = 2,
                   UserId = 2,
                   RoleId = 2,
                }
            };
          
        }

        public new async Task<IEnumerable<UserRole>> GetAllAsync()
        {
            var list = userroles.ToList();
            return await Task.FromResult<IEnumerable<UserRole>>(list);
        }

        public new async Task<UserRole> AddAsync(UserRole model)
        {
            userroles.Add(model);
            return await Task.FromResult<UserRole>(model);
        }

        public new async Task<UserRole> DeleteAsync(UserRole model)
        {
            userroles.Remove(model);
            return await Task.FromResult<UserRole>(model);
        }


        public new async Task<UserRole> GetByIdAsync(int id)
        {
            var find = userroles.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<UserRole>(find);
            }
        }

        public new Task<IEnumerable<UserRole>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<UserRole> UpdateAsync(UserRole model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }

    }
}
