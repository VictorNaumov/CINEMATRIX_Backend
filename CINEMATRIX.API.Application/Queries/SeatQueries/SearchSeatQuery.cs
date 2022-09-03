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

namespace CINEMATRIX.API.Application.Queries.SeatQueries
{
    public class SearchSeatQuery : PagedSearchQuery<FoundSeatDTO, SeatSearchCondition>
    {
        public SearchSeatQuery(SeatSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchSeatQueryHandler : IRequestHandler<SearchSeatQuery, PagedResponse<FoundSeatDTO>>
    {
        private readonly ISeatService _seatService;
        private readonly IMapper _mapper;

        public SearchSeatQueryHandler(ISeatService seatService, IMapper mapper)
        {
            _seatService = seatService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundSeatDTO>> Handle(SearchSeatQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.SortProperty = typeof(FoundSeatDTO).GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Seat> foundSeats = await _seatService.FindAsync(searchCondition);
            var mappedSeat = _mapper.Map<IEnumerable<FoundSeatDTO>>(foundSeats);
            var totalCount = await _seatService.CountAsync(searchCondition);

            return new PagedResponse<FoundSeatDTO>
            {
                Items = mappedSeat,
                TotalCount = totalCount
            };
        }
    }
}