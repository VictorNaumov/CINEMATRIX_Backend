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
    public interface IFAQService : IBaseService<FAQ>
    {
        Task<IReadOnlyCollection<FAQ>> FindAsync(FAQSearchCondition searchCondition);
        Task<long> CountAsync(FAQSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class FAQService : BaseService<FAQ>, IFAQService
    {
        public FAQService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<FAQ>> FindAsync(FAQSearchCondition searchCondition)
        {
            IQueryable<FAQ> query = BuildFindQuery(searchCondition);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(FAQSearchCondition searchCondition)
        {
            IQueryable<FAQ> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.FAQs.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<FAQ> BuildFindQuery(FAQSearchCondition searchCondition)
        {
            IQueryable<FAQ> query = _dbContext.FAQs;

            foreach (var question in searchCondition.Questions)
            {
                query = query.Where(x => x.Question != null && x.Question.ToUpper().Contains(question));
            }

            foreach (var answer in searchCondition.Answers)
            {
                query = query.Where(x => x.Answer != null && x.Answer.ToUpper().Contains(answer));
            }

            foreach (var category in searchCondition.Categories)
            {
                query = query.Where(x => x.Category != null && x.Category.ToUpper().Contains(category));
            }

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return query;
        }
    }
}
