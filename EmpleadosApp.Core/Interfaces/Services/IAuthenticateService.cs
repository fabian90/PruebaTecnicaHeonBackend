
using EmpleadosApp.Core.DTOs.Response;

namespace EmpleadosApp.Core.Interfaces.Services
{
    public interface IAuthenticateService
    {
        UserAuthResponseDTO ValidateUser(string username, string password);
    }
}
