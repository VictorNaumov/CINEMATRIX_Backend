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
        Task<List<FoundGenreDTO>> FindAsync(GenreSearchCondition searchCondition, string sortProperty);
        Task<FoundGenreDTO> GetAsync(long? id, CancellationToken cancellationToken);
    }

    public class GenreService : HttpBaseService, IGenreService
    {
        const string Url = "https://api.themoviedb.org/3/genre/movie/list?api_key={0}&language=en-US";
        public GenreService() { }

        public async Task<List<FoundGenreDTO>> FindAsync(GenreSearchCondition searchCondition, string sortProperty)
        {
            var apiResponse = await GetByUrlAsync<GenreResponse>(Url);

            var genres = searchCondition.SortDirection != "desc"
                ? apiResponse.Genres.OrderBy(sortProperty)
                : apiResponse.Genres.OrderByDescending(sortProperty);

            return genres;
        }

        public async Task<FoundGenreDTO> GetAsync(long? id, CancellationToken cancellationToken = default)
        {
            if (!id.HasValue)
            {
                return null;
            }

            var apiResponse = await GetByUrlAsync<GenreResponse>(Url, id.GetValueOrDefault());

            return apiResponse.Genres.FirstOrDefault(x => x.Id == id);
        }
    }
}
