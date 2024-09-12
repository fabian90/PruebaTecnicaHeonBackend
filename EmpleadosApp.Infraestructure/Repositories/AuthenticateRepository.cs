using Commons.Repository.Repository;
using EmpleadosApp.Core.Entities;
using EmpleadosApp.Core.Interfaces.Repositories;
using EmpleadosApp.Infrastructure.Data;

namespace EmpleadosApp.Infrastructure.Repositories
{
    public class AuthenticateRepository : GenericRepository<User, IdentityDBContext>, IAuthenticateRepository
    {
        protected readonly IdentityDBContext _context;

        public AuthenticateRepository(IdentityDBContext context) : base(context)
        {
            _context = context;
        }     
    }
}

