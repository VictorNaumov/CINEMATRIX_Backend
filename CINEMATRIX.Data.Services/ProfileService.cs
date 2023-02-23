using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IProfileService : IBaseService<Profile>
    {
        Task<bool> ExistAsync(long id, CancellationToken cancellationToken);
    }

    public class ProfileService : BaseService<Profile>, IProfileService
    {
        public ProfileService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<bool> ExistAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Profile.AnyAsync(entity => entity.Id == id, cancellationToken);
        }
    }
}
