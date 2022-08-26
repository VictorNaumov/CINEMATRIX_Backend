using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;

namespace CINEMATRIX.Data.Services
{
    public interface IRoleService : IBaseService<Role> { }

    public class RoleService : BaseService<Role>, IRoleService
    {
        public RoleService(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
