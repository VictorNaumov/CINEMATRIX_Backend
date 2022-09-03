using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IGenreService : IHttpBaseService
    {
        Task<List<FoundGenreDTO>> FindAsync(GenreSearchCondition searchCondition, CancellationToken cancellationToken);
        Task<FoundGenreDTO> GetByIdAsync(long? id, CancellationToken cancellationToken);
    }

    public class GenreService : HttpBaseService, IGenreService
    {
        public GenreService() { }

        public async Task<List<FoundGenreDTO>> FindAsync(GenreSearchCondition searchCondition, 
            CancellationToken cancellationToken)
        {
            string url = $"https://api.themoviedb.org/3/genre/movie/list?api_key={ApiKey}&language=en-US";

            var apiResponse = await GetByUrlAsync<GenreResponse>(url);

            var genres = searchCondition.SortDirection != "desc"
                ? apiResponse.Genres.OrderBy(searchCondition.SortProperty)
                : apiResponse.Genres.OrderByDescending(searchCondition.SortProperty);

            return genres;
        }

        public async Task<FoundGenreDTO> GetByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            string url = $"https://api.themoviedb.org/3/genre/movie/list?api_key={ApiKey}&language=en-US";

            var apiResponse = await GetByUrlAsync<GenreResponse>(url);

            return apiResponse.Genres.FirstOrDefault(x => x.Id == id);
        }
    }
}
