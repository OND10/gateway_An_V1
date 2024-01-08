using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Application.Services;
using UserManagement_Domain.Interfaces;
using UserManagement_Infustracture.DBContext;
using UserManagement_Infustracture.GraphQl;
using UserManagement_Infustracture.Implementation;

namespace UserManagement_Infustracture.Extension
{
    public static class AddPresistenceExtension
    {
        public static IServiceCollection AddPresistence(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddGraphQL(u => SchemaBuilder.New().AddServices(u)
            .AddType<UserType>()
            .AddQueryType<UserQuery>()
            .Create()
        );

            return services;
        }
    }
}
