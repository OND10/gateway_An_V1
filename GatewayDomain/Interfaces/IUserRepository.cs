using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Entities;
using UserManagement_Domain.IRepositories;

namespace UserManagement_Domain.Interfaces
{
    public interface IUserRepository:IGenericRepository<User>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
