using Commons.Repository.Entities;

namespace EmpleadosApp.Core.Entities
{
    public class Role : BaseEntity
    {
        
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }

        
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
