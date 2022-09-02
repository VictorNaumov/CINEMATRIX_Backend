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
    public interface IMovieService : IHttpBaseService
    {
        Task<List<FoundMovieDTO>> FindAsync(MovieSearchCondition searchCondition, string sortProperty);
        Task<FoundMovieDTO> GetAsync(long? id, CancellationToken cancellationToken);
    }

    public class MovieService : HttpBaseService, IMovieService
    {
        const string Url = "https://api.themoviedb.org/3/movie/movie/list?api_key={0}&language=en-US";
        public MovieService() { }

        public async Task<List<FoundMovieDTO>> FindAsync(MovieSearchCondition searchCondition, string sortProperty)
        {
            string apiResponse = await GetByUrlAsync(Url);

            var movies = DeserializeResponse(apiResponse);

            movies = searchCondition.SortDirection != "desc"
                ? movies.OrderBy(sortProperty)
                : movies.OrderByDescending(sortProperty);

            return movies;
        }

        public async Task<FoundMovieDTO> GetAsync(long? id, CancellationToken cancellationToken = default)
        {
            string apiResponse = await GetByUrlAsync(Url);

            var movies = DeserializeResponse(apiResponse);

            var requestedMovie = movies.FirstOrDefault(x => x.Id == id);

            return requestedMovie;
        }

        private List<FoundMovieDTO> DeserializeResponse(string apiResponse)
        {
            var movies = new List<FoundMovieDTO>();

            if (!string.IsNullOrWhiteSpace(apiResponse))
            {
                IDictionary<string, List<FoundMovieDTO>> responseDictionary = JsonConvert.DeserializeObject<IDictionary<string, List<FoundMovieDTO>>>(apiResponse);

                if (responseDictionary != null && responseDictionary.ContainsKey("movies"))
                {
                    movies = responseDictionary["movies"];
                }
            }

            return movies;
        }
    }
}
