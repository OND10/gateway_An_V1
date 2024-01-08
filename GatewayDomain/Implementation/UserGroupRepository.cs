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
    public class UserGroupRepository: GenericRepository<UserGroup>, IUserGroupRepository
    {

        public List<UserGroup> usergroups;
   
        public UserGroupRepository()
        {
            usergroups = new List<UserGroup>()
            {
                new UserGroup
                {
                    Id = 1,
                    UserId = 1,
                    GroupId = 1,
                },
                new UserGroup
                {
                    Id = 2,
                    UserId = 2,
                    GroupId = 2,
                }
            };
        }


        public new async Task<IEnumerable<UserGroup>> GetAllAsync()
        {
            var list = usergroups.ToList();
            return await Task.FromResult<IEnumerable<UserGroup>>(list);
        }

        public new async Task<UserGroup> AddAsync(UserGroup model)
        {
            usergroups.Add(model);
            return await Task.FromResult<UserGroup>(model);
        }

        public new async Task<UserGroup> DeleteAsync(UserGroup model)
        {
            usergroups.Remove(model);
            return await Task.FromResult<UserGroup>(model);
        }


        public new async Task<UserGroup> GetByIdAsync(int id)
        {
            var find = usergroups.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<UserGroup>(find);
            }
        }

        public new Task<IEnumerable<UserGroup>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<UserGroup> UpdateAsync(UserGroup model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }

    }
}
