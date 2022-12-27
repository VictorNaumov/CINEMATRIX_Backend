using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.FavoriteMovieQueries
{
    public class SearchFavoriteMovieQuery : PagedSearchQuery<FoundFavoriteMovieDTO, FavoriteMovieSearchCondition>
    {
        public SearchFavoriteMovieQuery(FavoriteMovieSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchFavoriteMovieQueryHandler : IRequestHandler<SearchFavoriteMovieQuery, PagedResponse<FoundFavoriteMovieDTO>>
    {
        private readonly IFavoriteMovieService _FavoriteMovieService;
        private readonly IMapper _mapper;

        public SearchFavoriteMovieQueryHandler(IFavoriteMovieService FavoriteMovieService, IMapper mapper)
        {
            _FavoriteMovieService = FavoriteMovieService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundFavoriteMovieDTO>> Handle(SearchFavoriteMovieQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.SortProperty = typeof(FoundFavoriteMovieDTO).GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<FavoriteMovie> foundFavoriteMovies = await _FavoriteMovieService.FindAsync(searchCondition);

            var mappedFavoriteMovie = _mapper.Map<IEnumerable<FoundFavoriteMovieDTO>>(foundFavoriteMovies);
            var totalCount = await _FavoriteMovieService.CountAsync(searchCondition);

            return new PagedResponse<FoundFavoriteMovieDTO>
            {
                Items = mappedFavoriteMovie,
                TotalCount = totalCount
            };
        }
    }
}