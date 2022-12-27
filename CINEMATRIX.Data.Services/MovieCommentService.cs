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
    public interface IMovieCommentService : IBaseService<MovieComment>
    {
        Task<IReadOnlyCollection<MovieComment>> FindAsync(MovieCommentSearchCondition searchCondition);
        Task<IReadOnlyCollection<MovieComment>> GetByMovieIdAsync(long movieId, CancellationToken cancellationToken);
        Task<IReadOnlyCollection<MovieComment>> GetByProfileIdAsync(long userId, CancellationToken cancellationToken);
        Task<long> CountAsync(MovieCommentSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class MovieCommentService : BaseService<MovieComment>, IMovieCommentService
    {
        public MovieCommentService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<MovieComment>> FindAsync(MovieCommentSearchCondition searchCondition)
        {
            IQueryable<MovieComment> query = BuildFindQuery(searchCondition);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<IReadOnlyCollection<MovieComment>> GetByMovieIdAsync(long movieId, CancellationToken cancellationToken)
        {
            return await _dbSet.Where(c => c.MovieId == movieId)
                .Include(q => q.ParentComment)
                .Include(q => q.Replies)
                .ToListAsync();
        }

        public async Task<IReadOnlyCollection<MovieComment>> GetByProfileIdAsync(long profileId, CancellationToken cancellationToken)
        {
            return await _dbSet.Where(c => c.ProfileId == profileId)
                .Include(q => q.ParentComment)
                .Include(q => q.Replies)
                .ToListAsync();
        }

        public async Task<long> CountAsync(MovieCommentSearchCondition searchCondition)
        {
            IQueryable<MovieComment> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.MovieComments.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<MovieComment> BuildFindQuery(MovieCommentSearchCondition searchCondition)
        {
            IQueryable<MovieComment> query = _dbContext.MovieComments;

            query = query.Where(x => searchCondition.StartDateTime.Date <= x.DateTime.Date && x.DateTime.Date <= searchCondition.EndDateTime.Date);

            if (searchCondition.ParentCommentIds.Any())
            {
                query = query.Where(x => searchCondition.ParentCommentIds.Contains(x.ParentCommentId.Value));
            }

            if (searchCondition.MovieIds.Any())
            {
                query = query.Where(x => searchCondition.MovieIds.Contains(x.MovieId));
            }

            if (searchCondition.ProfileIds.Any())
            {
                query = query.Where(x => searchCondition.ProfileIds.Contains(x.ProfileId));
            }

            foreach (var text in searchCondition.Text)
            {
                query = query.Where(x => x.Text != null && x.Text.ToUpper().Contains(text));
            }

            if (searchCondition.NeedLoadDependencies)
            {
                query.Include(q => q.ParentComment)
                    .Include(q => q.Replies);
            }

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return query;
        }
    }
}
