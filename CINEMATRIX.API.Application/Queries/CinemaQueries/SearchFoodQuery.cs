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

namespace CINEMATRIX.API.Application.Queries.CinemaQueries
{
    public class SearchCinemaQuery : PagedSearchQuery<FoundCinemaDTO, CinemaSearchCondition>
    {
        public SearchCinemaQuery(CinemaSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchCinemaQueryHandler : IRequestHandler<SearchCinemaQuery, PagedResponse<FoundCinemaDTO>>
    {
        private readonly ICinemaService _cinemaService;
        private readonly IMapper _mapper;

        public SearchCinemaQueryHandler(ICinemaService cinemaService, IMapper mapper)
        {
            _cinemaService = cinemaService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundCinemaDTO>> Handle(SearchCinemaQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();

            IReadOnlyCollection<Cinema> foundCinemas = await _cinemaService.FindAsync(searchCondition);
            var mappedCinema = _mapper.Map<IEnumerable<FoundCinemaDTO>>(foundCinemas);
            var totalCount = await _cinemaService.CountAsync(searchCondition);

            return new PagedResponse<FoundCinemaDTO>
            {
                Items = mappedCinema,
                TotalCount = totalCount
            };
        }
    }
}