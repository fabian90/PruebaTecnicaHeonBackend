using Commons.RequestFilter;
using Commons.Response;
using EmpleadosApp.Core.DTOs.Request;
using EmpleadosApp.Core.DTOs.Response;
using EmpleadosApp.Core.Entities;

namespace EmpleadosApp.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> GetByUserName(string userName);
        Task<ApiResponse<UserResponseDTO>> Add(UserRequestDTO request);
        Task<ApiResponse<UserResponseDTO>> Update(UserRequestDTO request);
        Task<ApiResponse<object>> Delete(int id);
        Task<RecordsResponse<UserResponseDTO>> Get(QueryFilter filter);
    }
}