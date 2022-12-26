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
    public interface IHallService : IBaseService<Hall>
    {
        Task<IReadOnlyCollection<Hall>> FindAsync(HallSearchCondition searchCondition);
        Task<long> CountAsync(HallSearchCondition searchCondition);
        Task<bool> ExistsAsync(long id, CancellationToken cancellationToken);
    }

    public class HallService : BaseService<Hall>, IHallService
    {
        public HallService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<IReadOnlyCollection<Hall>> FindAsync(HallSearchCondition searchCondition)
        {
            IQueryable<Hall> query = BuildFindQuery(searchCondition);

            return await query.Page(searchCondition.PageSize, searchCondition.Page).ToListAsync();
        }

        public async Task<long> CountAsync(HallSearchCondition searchCondition)
        {
            IQueryable<Hall> query = BuildFindQuery(searchCondition);

            var count = await query.LongCountAsync();

            return (long)Math.Ceiling((double)count / searchCondition.PageSize);
        }

        public async Task<bool> ExistsAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Halls.AnyAsync(entity => entity.Id == id, cancellationToken);
        }

        private IQueryable<Hall> BuildFindQuery(HallSearchCondition searchCondition)
        {
            IQueryable<Hall> query = _dbContext.Halls;

            foreach (var name in searchCondition.Name)
            {
                query = query.Where(x => x.Name != null && x.Name.Contains(name));
            }

            foreach (var description in searchCondition.Description)
            {
                query = query.Where(x => x.Description != null && x.Description.Contains(description));
            }

            foreach (var soundSystem in searchCondition.SoundSystem)
            {
                query = query.Where(x => x.SoundSystem != null && x.SoundSystem.Contains(soundSystem));
            }

            foreach (var projector in searchCondition.Projector)
            {
                query = query.Where(x => x.Projector != null && x.Projector.Contains(projector));
            }

            foreach (var screen in searchCondition.Screen)
            {
                query = query.Where(x => x.Screen != null && x.Screen.Contains(screen));
            }

            foreach (var screenResolution in searchCondition.ScreenResolution)
            {
                query = query.Where(x => x.ScreenResolution != null && x.ScreenResolution.Contains(screenResolution));
            }

            query = searchCondition.SortDirection != "desc"
                ? query.OrderBy(searchCondition.SortProperty)
                : query.OrderByDescending(searchCondition.SortProperty);

            return query;
        }
    }
}
