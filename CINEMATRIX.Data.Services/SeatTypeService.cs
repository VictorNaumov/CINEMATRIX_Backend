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
    public interface ISeatTypeService : IBaseService<SeatType>
    {
        Task<IReadOnlyCollection<SeatType>> FindAsync(SeatTypeSearchCondition searchCondition);
        Task<long> CountAsync(SeatTypeSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class SeatTypeService : BaseService<SeatType>, ISeatTypeService
    {
        public SeatTypeService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<SeatType>> FindAsync(SeatTypeSearchCondition searchCondition)
        {
            IQueryable<SeatType> query = BuildFindQuery(searchCondition);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(SeatTypeSearchCondition searchCondition)
        {
            IQueryable<SeatType> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.SeatTypes.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<SeatType> BuildFindQuery(SeatTypeSearchCondition searchCondition)
        {
            IQueryable<SeatType> query = _dbContext.SeatTypes;

            foreach (var name in searchCondition.Name)
            {
                query = query.Where(x => x.Name != null && x.Name.ToUpper().Contains(name));
            }

            query = query.Where(x => searchCondition.StartPrice <= x.Price && x.Price <= searchCondition.FinishPrice);

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return query;
        }
    }
}
