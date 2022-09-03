using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
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
            searchCondition.SortProperty = typeof(FoundMovieDTO).GetSortProperty(searchCondition.SortProperty);

            var movieTopRatedApiResponse = await _movieService.FindMoviesAsync(searchCondition, cancellationToken);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(movieTopRatedApiResponse);
        }
    }
}
