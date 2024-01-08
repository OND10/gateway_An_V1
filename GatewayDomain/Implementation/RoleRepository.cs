using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Common.Enums;
using UserManagement_Domain.Common.Exceptions;
using UserManagement_Domain.Entities;
using UserManagement_Domain.Interfaces;

namespace UserManagement_Infustracture.Implementation
{
    public class RoleRepository: GenericRepository<Role>, IRoleRepository
    {

        public List<Role> roles;
  
        public RoleRepository()
        {
            roles = new List<Role>()
            {
                new Role
                {
                    Id = Convert.ToInt16(RolesEnum.Admin),
                    Name ="Admin",
                    Description = "Controlling all users,endusers and managers in the system"
                },
                new Role
                {
                    Id = Convert.ToInt16(RolesEnum.User),
                    Name ="User",
                    Description = "Interacting with system as other users"
                }
            };
        }

        public new async Task<IEnumerable<Role>> GetAllAsync()
        {
            var list = roles.ToList();
            return await Task.FromResult<IEnumerable<Role>>(list);
        }

        public new async Task<Role> AddAsync(Role model)
        {
            roles.Add(model);
            return await Task.FromResult<Role>(model);
        }

        public new async Task<Role> DeleteAsync(Role model)
        {
            roles.Remove(model);
            return await Task.FromResult<Role>(model);
        }


        public new async Task<Role> GetByIdAsync(int id)
        {
            var find = roles.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<Role>(find);
            }
        }

        public new Task<IEnumerable<Role>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<Role> UpdateAsync(Role model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }

    }
}
