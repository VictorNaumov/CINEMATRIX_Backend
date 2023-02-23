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
    public interface IMovieService : IHttpBaseService
    {
        Task<PagedMoviesResponse> GetSimilarMoviesByIdAsync(long? id, MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default);
        Task<PagedMoviesResponse> GetTopRatedMoviesAsync(MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default);
        Task<PagedMoviesResponse> GetNowPlayingMoviesAsync(MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default);
        Task<PagedMoviesResponse> FindMoviesAsync(MovieSearchCondition searchCondition, CancellationToken cancellationToken = default);
        Task<PagedMoviesResponse> DiscoverMoviesAsync(DiscoverMovieSearchCondition searchCondition, CancellationToken cancellationToken = default);
        Task<List<MovieDetailByIdResponse>> GetByIdsWithRelationsAsync(long[] ids, CancellationToken cancellationToken = default);
        Task<MovieDetailByIdResponse> GetByIdWithRelationsAsync(long? id, CancellationToken cancellationToken);
        Task<List<MovieDetailByIdResponse>> GetByIdsAsync(long[] id, CancellationToken cancellationToken);
        Task<MovieDetailByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken);
    }

    public class MovieService : HttpBaseService, IMovieService
    {
        private const string _baseUrl = "https://api.themoviedb.org/3/";

        public MovieService() { }

        public async Task<PagedMoviesResponse> GetSimilarMoviesByIdAsync(long? id, MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/{id}/similar?api_key={ApiKey}&language=en-US&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);
            apiResponse.Results = SortResultApiResponse(apiResponse, searchCondition);

            return apiResponse;
        }

        public async Task<PagedMoviesResponse> GetTopRatedMoviesAsync(MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/top_rated?api_key={ApiKey}&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);
            apiResponse.Results = SortResultApiResponse(apiResponse, searchCondition);

            return apiResponse;
        }

        public async Task<PagedMoviesResponse> GetNowPlayingMoviesAsync(MovieSearchCondition searchCondition,
            CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/now_playing?api_key={ApiKey}&language=en-US&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);
            apiResponse.Results = SortResultApiResponse(apiResponse, searchCondition);

            return apiResponse;
        }

        public async Task<List<MovieDetailByIdResponse>> GetByIdsWithRelationsAsync(long[] ids, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/{string.Join(",", ids)}?api_key={ApiKey}&append_to_response=images,videos,credits";

            return await GetByUrlAsync<List<MovieDetailByIdResponse>>(url);
        }

        public async Task<MovieDetailByIdResponse> GetByIdWithRelationsAsync(long? id, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/{id}?api_key={ApiKey}&append_to_response=images,videos,credits";

            return await GetByUrlAsync<MovieDetailByIdResponse>(url);
        }

        public async Task<List<MovieDetailByIdResponse>> GetByIdsAsync(long[] ids, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/{string.Join(",", ids)}?api_key={ApiKey}";

            return await GetByUrlAsync<List<MovieDetailByIdResponse>>(url);
        }
        
        public async Task<MovieDetailByIdResponse> GetByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"movie/{id}?api_key={ApiKey}";

            return await GetByUrlAsync<MovieDetailByIdResponse>(url);
        }

        public async Task<PagedMoviesResponse> FindMoviesAsync(MovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"search/movie?api_key={ApiKey}&query={searchCondition.SearchString.ToQueryString()}&page={searchCondition.Page + 1}";

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);
            apiResponse.Results = SortResultApiResponse(apiResponse, searchCondition);

            return apiResponse;
        }

        public async Task<PagedMoviesResponse> DiscoverMoviesAsync(DiscoverMovieSearchCondition searchCondition, CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + $"discover/movie?api_key={ApiKey}&page={searchCondition.Page + 1}";
            url = ApplyDiscoverFiltersForUrl(url, searchCondition);

            var apiResponse = await GetByUrlAsync<PagedMoviesResponse>(url);

            return apiResponse;
        }

        private List<MovieResponse> SortResultApiResponse(PagedMoviesResponse apiResponse, MovieSearchCondition searchCondition) =>
            searchCondition.SortDirection != "desc"
                ? apiResponse.Results.OrderBy(searchCondition.SortProperty)
                : apiResponse.Results.OrderByDescending(searchCondition.SortProperty);

        private string ApplyDiscoverFiltersForUrl(string url, DiscoverMovieSearchCondition searchCondition)
        {
            if (searchCondition is null)
                return url;

            if (searchCondition.Genres.Any())
                url += $"&with_genres={string.Join("", searchCondition.Genres)}";

            if (searchCondition.People.Any())
                url += $"&with_people={string.Join("", searchCondition.People)}";

            if (searchCondition.SortProperty.Length > 0)
                url += $"&sort_by={searchCondition.SortProperty}";

            return url;
        }
    }
}
