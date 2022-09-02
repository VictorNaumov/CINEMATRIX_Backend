using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Services.Abstraction;
using CINEMATRIX.Data.Services.Extensions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services
{
    public interface IMovieService : IHttpBaseService
    {
        Task<PagedMoviesResponse> GetTopRatedMoviesAsync(MovieSearchCondition searchCondition, string sortProperty);
        Task<PagedMoviesResponse> GetNowPlayingMoviesAsync(MovieSearchCondition searchCondition, string sortProperty);
        Task<MovieByIdResponse> GetMovieByIdAsync(long? id, CancellationToken cancellationToken);
    }

    public class MovieService : HttpBaseService, IMovieService
    {
        public MovieService() { }

        public async Task<PagedMoviesResponse> GetTopRatedMoviesAsync(MovieSearchCondition searchCondition, string sortProperty)
        {
            string url = $"https://api.themoviedb.org/3/movie/top_rated?api_key={ApiKey}&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);

            apiResponse.Results = searchCondition.SortDirection != "desc"
                ? apiResponse.Results.OrderBy(sortProperty)
                : apiResponse.Results.OrderByDescending(sortProperty);

            return apiResponse;
        }

        public async Task<PagedMoviesResponse> GetNowPlayingMoviesAsync(MovieSearchCondition searchCondition, string sortProperty)
        {
            string url = $"https://api.themoviedb.org/3/movie/now_playing?api_key={ApiKey}&language=en-US&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);

            apiResponse.Results = searchCondition.SortDirection != "desc"
                ? apiResponse.Results.OrderBy(sortProperty)
                : apiResponse.Results.OrderByDescending(sortProperty);

            return apiResponse;
        }

        public async Task<MovieByIdResponse> GetMovieByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            string url = $"https://api.themoviedb.org/3/movie/{ApiKey}?api_key={id}&append_to_response=images,videos";

            return await GetByUrlAsync<MovieByIdResponse>(url, id.GetValueOrDefault());
        }
    }
}
