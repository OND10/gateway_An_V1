using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Domain.Interfaces
{
    public interface IManagerRepository
    {
        IUserRepository UserRepository { get; }

        //IRoleRepository RoleRepository { get; }

        //IUserRoleRepository UserRoleRepository { get; }

        //IGroupRepository GroupRepository { get; }

        //IPermissionRepository PermissionRepository { get; }

        //IPermissionRoleRepository PermissionRoleRepository { get; }

        //IUserGroupRepository UserGroupRepository { get; }




    }
}
