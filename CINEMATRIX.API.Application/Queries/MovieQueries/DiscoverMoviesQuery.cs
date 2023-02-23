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
    public class DiscoverMoviesQuery : PagedSearchQuery<FoundMovieDTO, DiscoverMovieSearchCondition>
    {
        public DiscoverMoviesQuery(DiscoverMovieSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class DiscoverMoviesQueryHandler : IRequestHandler<DiscoverMoviesQuery, PagedResponse<FoundMovieDTO>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public DiscoverMoviesQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieDTO>> Handle(DiscoverMoviesQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.SortProperty = typeof(FoundMovieDTO).GetSortProperty(searchCondition.SortProperty);

            var discoverMoviesApiResponse = await _movieService.DiscoverMoviesAsync(searchCondition, cancellationToken);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(discoverMoviesApiResponse);
        }
    }
}
