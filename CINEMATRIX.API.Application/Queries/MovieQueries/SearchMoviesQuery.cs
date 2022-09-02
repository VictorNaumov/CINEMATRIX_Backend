using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.MovieQueries
{
    public class SearchMoviesQuery : PagedSearchQuery<FoundMovieDTO, MovieSearchCondition>
    {
        public SearchMoviesQuery(MovieSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchMoviesQueryHandler : IRequestHandler<SearchMoviesQuery, PagedResponse<FoundMovieDTO>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public SearchMoviesQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieDTO>> Handle(SearchMoviesQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.SortProperty = GetSortProperty(searchCondition.SortProperty);

            var movieTopRatedApiResponse = await _movieService.FindMoviesAsync(searchCondition, cancellationToken);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(movieTopRatedApiResponse);
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "title": return nameof(FoundMovieDTO.Title);
                    case "overview": return nameof(FoundMovieDTO.Overview);
                    case "budget": return nameof(FoundMovieDTO.Budget);
                    case "originallanguage": return nameof(FoundMovieDTO.OriginalLanguage);
                    case "originaltitle": return nameof(FoundMovieDTO.OriginalTitle);
                    case "popularity": return nameof(FoundMovieDTO.Popularity);
                    case "releasedate": return nameof(FoundMovieDTO.ReleaseDate);
                    case "runtime": return nameof(FoundMovieDTO.Runtime);
                    case "status": return nameof(FoundMovieDTO.Status);
                    case "tagline": return nameof(FoundMovieDTO.Tagline);
                    case "voteaverage": return nameof(FoundMovieDTO.VoteAverage);
                    case "votecount": return nameof(FoundMovieDTO.VoteCount);
                }
            }

            return nameof(FoundMovieDTO.Id);
        }
    }
}
