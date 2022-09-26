using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface ITicketService : IBaseService<Ticket>
    {
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
        Task<IReadOnlyCollection<Ticket>> GetTicketsBySessionId(long sessionId, CancellationToken cancellationToken);
    }

    public class TicketService : BaseService<Ticket>, ITicketService
    {
        public TicketService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        public async Task<IReadOnlyCollection<Ticket>> GetTicketsBySessionId(long sessionId, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets.Where(entity => entity.SessionId == sessionId).AsNoTracking().ToListAsync();
        }
    }
}
