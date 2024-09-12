using Commons.Repository.Interfaces;
using Commons.RequestFilter;
using Commons.Response;
using EmpleadosApp.Core.DTOs.Response;
using EmpleadosApp.Core.Entities;

namespace EmpleadosApp.Core.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> GetByUserName(string userName);
        Task<RecordsResponse<UserResponseDTO>> Get(QueryFilter filter);

    }
}
