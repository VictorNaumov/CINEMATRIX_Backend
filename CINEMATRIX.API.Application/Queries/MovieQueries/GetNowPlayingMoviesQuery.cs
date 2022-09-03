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
    public class GetNowPlayingMoviesQuery : PagedSearchQuery<FoundMovieDTO, MovieSearchCondition>
    {
        public GetNowPlayingMoviesQuery(MovieSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class GetNowPlayingMoviesQueryHandler : IRequestHandler<GetNowPlayingMoviesQuery, PagedResponse<FoundMovieDTO>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetNowPlayingMoviesQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieDTO>> Handle(GetNowPlayingMoviesQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Title = request.SearchCondition.Title.GetFilterValues();
            searchCondition.SortProperty = typeof(FoundMovieDTO).GetSortProperty(searchCondition.SortProperty);

            var movieNowPlayingApiResponse = await _movieService.GetNowPlayingMoviesAsync(searchCondition);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(movieNowPlayingApiResponse);
        }
    }
}
