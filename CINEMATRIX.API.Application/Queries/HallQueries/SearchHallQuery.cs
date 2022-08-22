using AutoMapper;
using CINEMATRIX.API.Application.Queries.Abstractions;
using CINEMATRIX.API.Application.Queries.Extensions;
using CINEMATRIX.API.Contracts.Incoming.SearchConditions;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Queries.HallQueries
{
    public class SearchHallQuery : PagedSearchQuery<FoundHallDTO, HallSearchCondition>
    {
        public SearchHallQuery(HallSearchCondition searchCondition) : base(searchCondition) { }
    }

    public class SearchHallQueryHandler : IRequestHandler<SearchHallQuery, PagedResponse<FoundHallDTO>>
    {
        private readonly IHallService _hallService;
        private readonly IMapper _mapper;

        public SearchHallQueryHandler(IHallService hallService, IMapper mapper)
        {
            _hallService = hallService;
            _mapper = mapper;
        }

        public async Task<PagedResponse<FoundHallDTO>> Handle(SearchHallQuery request, CancellationToken cancellationToken)
        {
            var searchCondition = request.SearchCondition;
            searchCondition.Name = request.SearchCondition.Name.GetFilterValues();
            searchCondition.Description = request.SearchCondition.Description.GetFilterValues();
            searchCondition.SoundSystem = request.SearchCondition.SoundSystem.GetFilterValues();
            searchCondition.Projector = request.SearchCondition.Projector.GetFilterValues();
            searchCondition.Screen = request.SearchCondition.Screen.GetFilterValues();
            searchCondition.ScreenResolution = request.SearchCondition.ScreenResolution.GetFilterValues();

            var sortProperty = GetSortProperty(searchCondition.SortProperty);

            IReadOnlyCollection<Hall> foundHalls = await _hallService.FindAsync(searchCondition, sortProperty);
            var mappedHall = _mapper.Map<IEnumerable<FoundHallDTO>>(foundHalls);
            var totalCount = await _hallService.CountAsync(searchCondition);

            return new PagedResponse<FoundHallDTO>
            {
                Items = mappedHall,
                TotalCount = totalCount
            };
        }

        protected string GetSortProperty(string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                switch (propertyName.ToLowerInvariant())
                {
                    case "name": return nameof(Hall.Name);
                    case "description": return nameof(Hall.Description);
                    case "soundsystem": return nameof(Hall.SoundSystem);
                    case "projector": return nameof(Hall.Projector);
                    case "screen": return nameof(Hall.Screen);
                    case "screenresolution": return nameof(Hall.ScreenResolution);
                }
            }

            return nameof(Hall.Id);
        }
    }
}