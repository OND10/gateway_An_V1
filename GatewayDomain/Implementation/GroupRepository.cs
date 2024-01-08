using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Interfaces;
using UserManagement_Domain.Entities;
using UserManagement_Domain.Common.Exceptions;

namespace UserManagement_Infustracture.Implementation
{
    public class GroupRepository:GenericRepository<Group>,IGroupRepository
    {

        public List<Group> groups;
    
        public GroupRepository()
        {
            groups = new List<Group>()
            {
                new Group
                {
                    Id = 1,
                    Name = "SupervisonGroup",
                    Description = "Menitoring employees who recently got employeed",
                    UserGroups= new List<UserGroup>()
                    {
                        new UserGroup
                        {
                            Id=1,
                            UserId=1,
                            GroupId=1,
                        }
                    }
                },
                new Group
                {
                    Id = 2,
                    Name = "TestingGroup",
                    Description = "Test and Deploy Software",
                    UserGroups= new List<UserGroup>()
                    {
                        new UserGroup
                        {
                            Id=2,
                            UserId=2,
                            GroupId=2,
                        }
                    }
                }
            };
           
        }


        public new async Task<IEnumerable<Group>> GetAllAsync()
        {
            var list = groups.ToList();
            return await Task.FromResult<IEnumerable<Group>>(list);
        }

        public new async Task<Group> AddAsync(Group model)
        {
            groups.Add(model);
            return await Task.FromResult<Group>(model);
        }

        public new async Task<Group> DeleteAsync(Group model)
        {
            groups.Remove(model);
            return await Task.FromResult<Group>(model);
        }


        public new async Task<Group> GetByIdAsync(int id)
        {
            var find = groups.FirstOrDefault(x => x.Id == id);
            if (find == null)
            {
                throw new IdNullException("Exception : Id is Null");
            }
            else
            {
                return await Task.FromResult<Group>(find);
            }
        }

        public new Task<IEnumerable<Group>> Query(string query)
        {
            throw new ModelNullException(nameof(query), "Repo Query Exception");
        }

        public new Task<Group> UpdateAsync(Group model)
        {
            throw new ModelNullException(nameof(model), "Repo Update Exception");
        }
    }
}
