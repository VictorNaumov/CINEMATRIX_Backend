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
    public interface ICinemaService : IBaseService<Cinema>
    {
        Task<IReadOnlyCollection<Cinema>> FindAsync(CinemaSearchCondition searchCondition);
        Task<long> CountAsync(CinemaSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class CinemaService : BaseService<Cinema>, ICinemaService
    {
        public CinemaService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<Cinema>> FindAsync(CinemaSearchCondition searchCondition)
        {
            IQueryable<Cinema> query = BuildFindQuery(searchCondition);

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(CinemaSearchCondition searchCondition)
        {
            IQueryable<Cinema> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Cinemas.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<Cinema> BuildFindQuery(CinemaSearchCondition searchCondition)
        {
            IQueryable<Cinema> query = _dbContext.Cinemas;

            foreach (var name in searchCondition.Name)
            {
                query = query.Where(x => x.Name != null && x.Name.ToUpper().Contains(name));
            }

            return query;
        }
    }
}
