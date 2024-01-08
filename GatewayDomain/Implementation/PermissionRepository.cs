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
    public class PermissionRepository: GenericRepository<Permission>, IPermissionRepository
    {

        public List<Permission> permis;
      

        public PermissionRepository()
        {
            permis = new List<Permission>()
            {
                new Permission
                {
                   Id = 1,
                   Name = PermissionsEnum.Create.ToString(),
                   Description = "The ability to create many funds",
                   PermissionRoles = new List<PermissionRole>()
                   {
                       new PermissionRole
                       {
                         Id = 1,
                         PermissionId = 1,
                         RoleId = 1,
                       }
                   }
                },
                new Permission
                {
                   Id = 2,
                   Name = PermissionsEnum.Edit.ToString(),
                   Description = "The ability to update many funds",
                   PermissionRoles = new List<PermissionRole>()
                   {
                       new PermissionRole
                       {
                         Id = 2,
                         PermissionId = 2,
                         RoleId = 2,
                       }
                   }
                }
            };
        }

        public new async Task<IEnumerable<Permission>> GetAllAsync()
        {
            var list = permis.ToList();
            return await Task.FromResult<IEnumerable<Permission>>(list);
        }

        public new async Task<Permission> AddAsync(Permission model)
        {
            permis.Add(model);
            return await Task.FromResult<Permission>(model);
        }

        public new async Task<Permission> DeleteAsync(Permission model)
        {
            permis.Remove(model);
            return await Task.FromResult<Permission>(model);
        }


        public new async Task<Permission> GetByIdAsync(int id)
        {
            var find = permis.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<Permission>(find);
            }
        }

        public new Task<IEnumerable<Permission>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<Permission> UpdateAsync(Permission model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }

    }
}
