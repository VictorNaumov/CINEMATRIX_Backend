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
    public interface IFoodService : IBaseService<Food>
    {
        Task<IReadOnlyCollection<Food>> FindAsync(FoodSearchCondition searchCondition, string sortProperty);
        Task<long> CountAsync(FoodSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class FoodService : BaseService<Food>, IFoodService
    {
        public FoodService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<Food>> FindAsync(FoodSearchCondition searchCondition, string sortProperty)
        {
            IQueryable<Food> query = BuildFindQuery(searchCondition);

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(sortProperty)
                : query.OrderByDescending(sortProperty);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(FoodSearchCondition searchCondition)
        {
            IQueryable<Food> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Foods.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<Food> BuildFindQuery(FoodSearchCondition searchCondition)
        {
            IQueryable<Food> query = _dbContext.Foods;

            foreach (var name in searchCondition.Name)
            {
                query = query.Where(x => x.Name != null && x.Name.ToUpper().Contains(name));
            }

            foreach (var description in searchCondition.Description)
            {
                query = query.Where(x => x.Description != null && x.Description.ToUpper().Contains(description));
            }

            query = query.Where(x => searchCondition.StartPrice <= x.Price && x.Price <= searchCondition.FinishPrice);

            return query;
        }
    }
}
