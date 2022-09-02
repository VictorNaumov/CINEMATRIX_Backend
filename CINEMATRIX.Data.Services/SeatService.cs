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
    public interface ISeatService : IBaseService<Seat>
    {
        Task<IReadOnlyCollection<Seat>> FindAsync(SeatSearchCondition searchCondition);
        Task<long> CountAsync(SeatSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class SeatService : BaseService<Seat>, ISeatService
    {
        public SeatService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<Seat>> FindAsync(SeatSearchCondition searchCondition)
        {
            IQueryable<Seat> query = BuildFindQuery(searchCondition);

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(SeatSearchCondition searchCondition)
        {
            IQueryable<Seat> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Seats.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<Seat> BuildFindQuery(SeatSearchCondition searchCondition)
        {
            IQueryable<Seat> query = _dbContext.Seats;

            query = query.Where(x => searchCondition.Row.Contains(x.Row));
            query = query.Where(x => searchCondition.Number.Contains(x.Number));

            return query;
        }
    }
}
