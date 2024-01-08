using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Entities;
using UserManagement_Domain.IRepositories;

namespace UserManagement_Domain.Interfaces
{
    public interface IUserGroupRepository: IGenericRepository<UserGroup>
    {
    }
}
