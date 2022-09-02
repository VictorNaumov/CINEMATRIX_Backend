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

namespace CINEMATRIX.API.Application.Queries.SeatTypeQueries
{
    public class SearchSeatTypeQuery : PagedSearchQuery<FoundSeatTypeDTO, SeatTypeSearchCondition>
    {
        public SearchSeatTypeQuery(SeatTypeSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchSeatTypeQueryHandler : IRequestHandler<SearchSeatTypeQuery, PagedResponse<FoundSeatTypeDTO>>
    {
        private readonly ISeatTypeService _seatTypeService;
        private readonly IMapper _mapper;

        public SearchSeatTypeQueryHandler(ISeatTypeService seatTypeService, IMapper mapper)
        {
            _seatTypeService = seatTypeService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundSeatTypeDTO>> Handle(SearchSeatTypeQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
            searchCondition.SortProperty = GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<SeatType> foundSeatTypes = await _seatTypeService.FindAsync(searchCondition);
            var mappedSeatType = _mapper.Map<IEnumerable<FoundSeatTypeDTO>>(foundSeatTypes);
            var totalCount = await _seatTypeService.CountAsync(searchCondition);

            return new PagedResponse<FoundSeatTypeDTO>
            {
                Items = mappedSeatType,
                TotalCount = totalCount
            };
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "name": return nameof(SeatType.Name);
                    case "price": return nameof(SeatType.Price);
                }
            }

            return nameof(SeatType.Id);
        }
    }
}