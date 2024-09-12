using Commons.Repository.Interfaces;
using Commons.RequestFilter;
using Commons.Response;
using EmpleadosApp.Core.DTOs.Response;
using EmpleadosApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosApp.Core.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<Employee> GetByEmail(string email);
        Task<RecordsResponse<EmployeeResponseDTO>> Get(QueryFilter filter);
    }
}
