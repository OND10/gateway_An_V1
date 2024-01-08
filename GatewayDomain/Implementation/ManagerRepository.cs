using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Interfaces;

namespace UserManagement_Infustracture.Implementation
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly IUserRepository userRepository;
        //private readonly IRoleRepository roleRepository;
        //private readonly IUserRoleRepository userRoleRepository;
        //private readonly IGroupRepository groupRepository;
        //private readonly IUserGroupRepository userGroupRepository;
        //private readonly IPermissionRepository permissionRepository;
        //private readonly IPermissionRoleRepository permissionRoleRepository;
        public ManagerRepository(
            IUserRepository userRepository
            //IRoleRepository roleRepository,
            //IUserRoleRepository userRoleRepository,
            //IGroupRepository groupRepository,
            //IUserGroupRepository userGroupRepository,
            //IPermissionRepository permissionRepository,
            //IPermissionRoleRepository permissionRoleRepository
            )
        {
            this.userRepository = userRepository;
            //this.roleRepository = roleRepository;
            //this.userRoleRepository = userRoleRepository;
            //this.groupRepository = groupRepository;
            //this.userGroupRepository = userGroupRepository;
            //this.permissionRepository = permissionRepository;
            //this.permissionRoleRepository = permissionRoleRepository;

        }

        public IUserRepository UserRepository => userRepository;

        //public IRoleRepository RoleRepository => roleRepository;

        //public IUserRoleRepository UserRoleRepository => userRoleRepository;

        //public IGroupRepository GroupRepository => groupRepository;

        //public IPermissionRepository PermissionRepository => permissionRepository;

        //public IPermissionRoleRepository PermissionRoleRepository => permissionRoleRepository;

        //public IUserGroupRepository UserGroupRepository => userGroupRepository;
    }
}
