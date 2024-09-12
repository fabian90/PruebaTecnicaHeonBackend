using Identity.Core.Services;
using EmpleadosApp.Core.Interfaces.Repositories;
using EmpleadosApp.Core.Interfaces.Services;
using EmpleadosApp.Core.Services;
using EmpleadosApp.Infrastructure.Repositories;

namespace EmpleadosApp.API.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEntityService, EntityService>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            #endregion

            #region Repositories
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IEntityRepository, EntityRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            // Add any other services or repositories you need to inject here
        }
    }
}
