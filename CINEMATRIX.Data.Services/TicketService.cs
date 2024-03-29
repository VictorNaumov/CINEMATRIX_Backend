﻿using CINEMATRIX.Data.Domain.Models;
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
        Task<ICollection<Ticket>> GetTicketsBySessionId(long sessionId, CancellationToken cancellationToken);
        Task<ICollection<Ticket>> GetTicketsByProfileId(long profileId, CancellationToken cancellationToken);
    }

    public class TicketService : BaseService<Ticket>, ITicketService
    {
        public TicketService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        public async Task<ICollection<Ticket>> GetTicketsBySessionId(long sessionId, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets.Where(entity => entity.SessionId == sessionId).AsNoTracking().ToListAsync();
        }

        public async Task<ICollection<Ticket>> GetTicketsByProfileId(long profileId, CancellationToken cancellationToken)
        {
            return await _dbContext.Tickets
                .Include(s => s.Session)
                .ThenInclude(s => s.Hall)
                .Include(s => s.Seat)
                .ThenInclude(s => s.SeatType)
                .Where(entity => entity.ProfileId == profileId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
