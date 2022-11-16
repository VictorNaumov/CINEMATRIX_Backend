using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.Data.Domain.Enums;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.EF.SQL;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface ISessionService : IBaseService<Session>
    {
        Task<IReadOnlyCollection<Session>> FindAsync(SessionSearchCondition searchCondition);
        Task<long> CountAsync(SessionSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class SessionService : BaseService<Session>, ISessionService
    {
        public SessionService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<Session>> FindAsync(SessionSearchCondition searchCondition)
        {
            IQueryable<Session> query = BuildFindQuery(searchCondition);

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);



            return await query
                .Include(s => s.Hall)
                    .ThenInclude(h => h.Seats)
                        .ThenInclude(s => s.SeatType)
                .Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(SessionSearchCondition searchCondition)
        {
            IQueryable<Session> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Sessions.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<Session> BuildFindQuery(SessionSearchCondition searchCondition)
        {
            IQueryable<Session> query = _dbContext.Sessions;

            query = query.Where(x => searchCondition.StartDateTime.Date <= x.DateTime.Date && x.DateTime.Date <= searchCondition.EndDateTime.Date);

            if (searchCondition.HallIds.Length > 0)
            {
                query = query.Where(x => searchCondition.HallIds.Contains(x.HallId));
            }

            if (searchCondition.SeatTypeIds.Length > 0)
            {
                foreach (var seatTypeId in searchCondition.SeatTypeIds)
                {
                    query = query.Where(x => x.Hall.Seats.Any(s => s.SeatTypeId == seatTypeId));
                }
            }

            if (searchCondition.TimeSessions.Length > 0)
            {
                query = FilterBySessionTime(query, searchCondition);
            }

            return query;
        }

        private IQueryable<Session> FilterBySessionTime(IQueryable<Session> query, SessionSearchCondition searchCondition)
        {
            var timeSessionEnums = searchCondition.TimeSessions.Select(x => (TimeSessionEnum)x);
            var missingTimeSessionEnums = Enum.GetValues(typeof(TimeSessionEnum));

            foreach (var timeSessionEnum in timeSessionEnums)
            {
                // Morning (8 - 10)
                // Daytime (12 - 14)
                // Evening (16 - 18)
                // Night (20 - 22)
                switch (timeSessionEnum)
                {
                    case TimeSessionEnum.Morning:
                        {
                            query = query.Where(s => s.DateTime.Hour == 8 || s.DateTime.Hour == 10);
                            break;
                        }
                    case TimeSessionEnum.Daytime:
                        {
                            query = query.Where(s => s.DateTime.Hour == 12 || s.DateTime.Hour == 14);
                            break;
                        }
                    case TimeSessionEnum.Evening:
                        {
                            query = query.Where(s => s.DateTime.Hour == 16 || s.DateTime.Hour == 18);
                            break;
                        }
                    case TimeSessionEnum.Night:
                        {
                            query = query.Where(s => s.DateTime.Hour == 20 || s.DateTime.Hour == 22);
                            break;
                        }
                }
            }

            return query;
        }
    }
}