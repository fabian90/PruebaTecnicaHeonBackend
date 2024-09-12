using AutoMapper;
using EmpleadosApp.Core.DTOs.Request;
using EmpleadosApp.Core.DTOs.Response;
using EmpleadosApp.Core.Entities;

namespace EmpleadosApp.Infrastructure.Interfaces
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region User
            CreateMap<User, UserRequestDTO>();
            CreateMap<User, UserResponseDTO>();
            CreateMap<UserRequestDTO, User>();
            CreateMap<UserResponseDTO, User>();
            #endregion
            #region Employee
            CreateMap<Employee, EmployeeResponseDTO>()
            .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.Entity.Name)); // Asumiendo que Entity es una propiedad de navegació
            CreateMap<EmployeeRequestDTOUpdate, Employee>();
            CreateMap<EmployeeRequestDTOCreate, Employee>();
            CreateMap<EmployeeResponseDTO, Employee>();
            #endregion
            #region Entity
            CreateMap<Entity, EntityRequestDTOCreate>();
            CreateMap<Entity, EntityResponseDTO>();
            CreateMap<EntityRequestDTOCreate, Entity>();
            CreateMap<EntityRequestDTOUpdate, Entity>();
            CreateMap<EntityResponseDTO, Entity>();
            #endregion
        }
    }
}
