using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface ITicketService : IBaseService<Ticket>
    {
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class TicketService : BaseService<Ticket>, ITicketService
    {
        public TicketService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets.AnyAsync(entity => entity.Id == id, cancellationToken);
        }
    }
}
