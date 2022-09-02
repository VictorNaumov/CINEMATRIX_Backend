using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
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

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
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

            foreach (var movieName in searchCondition.MovieName)
            {
                query = query.Where(x => x.MovieName != null && x.MovieName.Contains(movieName));
            }

            query = query.Where(x => searchCondition.StartDateTime <= x.DateTime && x.DateTime <= searchCondition.EndDateTime);

            return query;
        }
    }
}