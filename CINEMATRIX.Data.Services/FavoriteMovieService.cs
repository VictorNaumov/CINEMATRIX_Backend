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
    public interface IFavoriteMovieService : IBaseService<FavoriteMovie>
    {
        Task<IReadOnlyCollection<FavoriteMovie>> FindAsync(FavoriteMovieSearchCondition searchCondition);
        Task<long> CountAsync(FavoriteMovieSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class FavoriteMovieService : BaseService<FavoriteMovie>, IFavoriteMovieService
    {
        public FavoriteMovieService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<FavoriteMovie>> FindAsync(FavoriteMovieSearchCondition searchCondition)
        {
            IQueryable<FavoriteMovie> query = BuildFindQuery(searchCondition);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(FavoriteMovieSearchCondition searchCondition)
        {
            IQueryable<FavoriteMovie> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.FavoriteMovies.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<FavoriteMovie> BuildFindQuery(FavoriteMovieSearchCondition searchCondition)
        {
            IQueryable<FavoriteMovie> query = _dbContext.FavoriteMovies;

            if (searchCondition.ProfileIds.Any())
            {
                query = query.Where(x => searchCondition.ProfileIds.Contains(x.MovieId));
            }

            if (searchCondition.MovieIds.Any())
            {
                query = query.Where(x => searchCondition.MovieIds.Contains(x.MovieId));
            }

            if (searchCondition.Ratings.Any())
            {
                query = query.Where(x => searchCondition.Ratings.Contains(x.Rating));
            }

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return query;
        }
    }
}
