using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using Newtonsoft.Json;
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
            string apiResponse = await GetByUrlAsync(Url);

            var genres = DeserializeResponse(apiResponse);

            genres = searchCondition.SortDirection != "desc"
                ? genres.OrderBy(sortProperty)
                : genres.OrderByDescending(sortProperty);

            return genres;
        }

        public async Task<FoundGenreDTO> GetAsync(long? id, CancellationToken cancellationToken = default)
        {
            string apiResponse = await GetByUrlAsync(Url);

            var genres = DeserializeResponse(apiResponse);

            var requestedGenre = genres.FirstOrDefault(x => x.Id == id);

            return requestedGenre;
        }

        private List<FoundGenreDTO> DeserializeResponse(string apiResponse)
        {
            var genres = new List<FoundGenreDTO>();

            if (!string.IsNullOrWhiteSpace(apiResponse))
            {
                var genreApiResponse = JsonConvert.DeserializeObject<GenreApiResponse>(apiResponse);

                genres = genreApiResponse.Genres;
            }

            return genres;
        }
    }
}
