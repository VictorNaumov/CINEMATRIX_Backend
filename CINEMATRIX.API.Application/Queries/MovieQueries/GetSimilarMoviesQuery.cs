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
    public class GetSimilarMoviesQuery : PagedSearchQuery<FoundMovieDTO, MovieSearchCondition>
    {
        public long Id { get; }

        public GetSimilarMoviesQuery(long id, MovieSearchCondition searchCondition) : base(searchCondition)
        {
            Id = id;
        }
    }

    public class GetSimilarMoviesQueryHandler : IRequestHandler<GetSimilarMoviesQuery, PagedResponse<FoundMovieDTO>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetSimilarMoviesQueryHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundMovieDTO>> Handle(GetSimilarMoviesQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Title = request.SearchCondition.Title.GetFilterValues();
            searchCondition.SortProperty = typeof(FoundMovieDTO).GetSortProperty(searchCondition.SortProperty);

            var movieTopRatedApiResponse = await _movieService.GetSimilarMoviesByIdAsync(request.Id, request.SearchCondition, cancellationToken);

            return _mapper.Map<PagedResponse<FoundMovieDTO>>(movieTopRatedApiResponse);
        }
    }
}
