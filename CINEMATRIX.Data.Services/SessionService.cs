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
                .Include(s => s.Tickets)
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

            //if (searchCondition.TimeSessions.Length > 0)
            //{
            //    query = FilterBySessionTime(query, searchCondition);
            //}

            return query;
        }

        //private IQueryable<Session> FilterBySessionTime(IQueryable<Session> query, SessionSearchCondition searchCondition)
        //{
        //var timeSessionEnums = searchCondition.TimeSessions.Select(x => (TimeSessionEnum)x);

        //foreach (var timeSessionEnum in timeSessionEnums)
        //{
        //    switch (timeSessionEnum)
        //    {
        //        case TimeSessionEnum.Morning: { 
        //                query = query.Where()
        //                break; }
        //        case TimeSessionEnum.Daytime: {
        //                break; }
        //        case TimeSessionEnum.Evening: { 
        //                break; }
        //        case TimeSessionEnum.Night: { 
        //                break; }
        //    }
        //}
        //}

    }
}