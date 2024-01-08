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
    public class PermissionRoleRepository: GenericRepository<PermissionRole>, IPermissionRoleRepository
    {
        public List<PermissionRole> perroles;

        public PermissionRoleRepository()
        {
            perroles = new List<PermissionRole>()
            {
                new PermissionRole
                {
                    Id = 1,
                    PermissionId = 1,
                    RoleId = 1,
                },
                new PermissionRole
                {
                    Id = 2,
                    PermissionId = 2,
                    RoleId = 2,
                }
            };
           
        }

        public new async Task<IEnumerable<PermissionRole>> GetAllAsync()
        {
            var list = perroles.ToList();
            return await Task.FromResult<IEnumerable<PermissionRole>>(list);
        }

        public new async Task<PermissionRole> AddAsync(PermissionRole model)
        {
            perroles.Add(model);
            return await Task.FromResult<PermissionRole>(model);
        }

        public new async Task<PermissionRole> DeleteAsync(PermissionRole model)
        {
            perroles.Remove(model);
            return await Task.FromResult<PermissionRole>(model);
        }


        public new async Task<PermissionRole> GetByIdAsync(int id)
        {
            var find = perroles.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<PermissionRole>(find);
            }
        }

        public new Task<IEnumerable<PermissionRole>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<PermissionRole> UpdateAsync(PermissionRole model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }
    }
}
